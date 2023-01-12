using System;
using System.Xml;
using System.IO;
using System.Linq;
using System.Net;

namespace CGI_PowerBaselineTwo_Scenarios.Utilities
{
    public static class POWER_WMSCommunication_WS_Nilfisk
    {
        private const string _url = "https://power-nilfiskbe-soap.emea.tst.api.itglo.net/CGI/WS/NILFISKBE/Codeunit/WMSCommunicationWS?tenant=nilfiskbe";

        private const string _action = "urn:microsoft-dynamics-schemas/codeunit/POWER_WMSCommunication_WS";

        public static void WebServicePostCall(string p0)
        {
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(p0);
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            // do something usefull here like update your UI.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.Write(soapResult);
            }
        }

        private static HttpWebRequest CreateWebRequest(string url, string action)
        {

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=utf-8";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            webRequest.UseDefaultCredentials = true;
            webRequest.PreAuthenticate = true;
            CredentialCache cache = new CredentialCache();
            cache.Add(new Uri(url), "Negotiate", new NetworkCredential("AT_CGI_ALL", "T+RhKS4*fvp3", "ITGLO"));
            webRequest.Credentials = cache;
            // webRequest.Credentials = CredentialCache.DefaultCredentials;
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope(string p0)
        {


            XmlDocument soapEnvelopeDocument = new XmlDocument();

            soapEnvelopeDocument.Load("\\\\itglo.net\\public\\EMEA\\BE-KI\\DataShares\\Share Analyze Consumers\\21 TEST TEAM\\Bashkim\\BCData\\\\NilfiskData\\" + p0);
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    }
}