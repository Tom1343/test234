using System;
using System.Xml;
using System.IO;
using System.Net;

namespace CGI_OUTBOUND_Android_Scenarios.Utilities
{
    class WebServiceCallCreateHolderBaselineTWODB
    {
        private static string _url = "https://power-baselinetwo-soap.emea.tst.api.itglo.net/CGI/WS/Codeunit/POWAutoTestingWS?tenant=baselinetwo";

        private static string _action = "urn:microsoft-dynamics-schemas/codeunit/AutoTestingWS:AutoTest_ImportConfigPackage";

        public static void WebServicePostCall(string p0)
        {
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(p0);
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            asyncResult.AsyncWaitHandle.WaitOne();

            string soapResult;


            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd().Substring(190, 8);
                }

                System.Diagnostics.Debug.WriteLine(soapResult);
                DataCollection.APICreateHolder = soapResult;

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
            // soapEnvelopeDocument.Load("C:\\Users\\Aliu\\Desktop\\file.xml");
            //soapEnvelopeDocument.Load("//ktn.group/Public/BE-KI/Datashares/Share Analyze Consumers/21 TEST TEAM/Bashkim/BCData/PutawaySAM/PackageSAM_BB_PUTWAY.xml");
            soapEnvelopeDocument.Load("//itglo.net/public/EMEA/BE-KI/Datashares/Share Analyze Consumers/21 TEST TEAM/Bashkim/BCData/BaselineData/" + p0);
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
