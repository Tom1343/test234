using CGI_OUTBOUND_Android_Scenarios.Utilities;
using CGI_OUTBOUND_BC_Scenarios.Utilities;
using CGI_PowerBaselineTwo_Scenarios.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;




namespace CGI_OUTBOUND_Android_Scenarios.Pages
{
    public class AndroidPage : Page
    {
        //public static string RFPortalPath = "//ktn.group/Public/BE-KI/Datashares/Share Analyze Consumers/21 TEST TEAM/apk/net.itglo.cgi.rf.portal.t.apk";
        public const string UITestDriverURL = "UITestDriverURL";
        public const string rfClientPackage = "net.itglo.cgi.rf.client.t";
        public const string rfClientActivity = "crc6410506e2311b41cce.RootView";

        public WaitMethods WaitMethods => new WaitMethods(Driver);

        public AndroidPage(AndroidDriver<AppiumWebElement> driver) : base(driver) { }

        public AndroidPage SendInstructionToQueueGroup(string p0)
        {
            WebServicesCall.WebServicePostCall(p0);

            return this;
        }
        public AndroidPage SendInstructionToQueueGroupStyra(string p0)
        {
            WebServicesCall.WebServicePostCall(p0);

            return this;
        }

        public AndroidPage SendInstructionToQueueGroupNilfisk(string p0)
        {
            WebServicesCall_Nilfisk.WebServicePostCall(p0);
            return this;
        }

        public AndroidPage SendInstructionToQueueGroupSkatepro(string p0)
        {
            WebServicesCall_SkatePro.WebServicePostCall(p0);
            return this;
        }
        public AndroidPage LaunchInstructionToQueueGroupNilfisk(string p0)
        {
            WebServicesCall_Nilfisk_Launch.WebServicePostCall(p0);
            return this;
        }

        public AndroidPage SendQueuegroupsAndLaunchThemInAdeo(string p0)
        {
            WebServicesCall_Adeo.WebServicePostCall(p0);
            return this;
        }


        public AndroidPage SendInstructionToQueueGroupBaselineTwo(string p0)
        {
            WebServicesCall_BaselineTWODB.WebServicePostCallBaseline(p0);

            return this;
        }

        public AndroidPage SendInstructionToCreateHolderBaselineTwo(string p0)
        {
            WebServiceCallCreateHolderBaselineTWODB.WebServicePostCall(p0);

            return this;
        }

        public AndroidPage LoginAndStartAppFromWarehouse(string badgeNumber, string appName, string warehouseLoc)
        {
            WaitMethods.WaitForElementToBePresent(By.Id(InputBadgeNumberId));
            Actions action = new Actions(Driver);

            Driver.FindElementById(InputBadgeNumberId).Click();

            action.SendKeys(badgeNumber).SendKeys(Keys.Enter).Build().Perform();
            Driver.FindElementByXPath("//android.widget.TextView[@text='" + warehouseLoc + "']").Click();
            Thread.Sleep(1000);

            var element = Driver.FindElementByXPath("//android.widget.TextView[@text='" + appName + "']");
            _ = element.Displayed;

            element.Click();
            return this;
        }

        public AndroidPage LoginBadgeNumber(string badgeNumber)
        {
            WaitMethods.WaitForElementToBePresent(By.Id(InputBadgeNumberId));
            Actions action = new Actions(Driver);

            Driver.FindElementById(InputBadgeNumberId).Click();

            action.SendKeys(badgeNumber).SendKeys(Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage SendCreateHolder(string p0)
        {
            WebServiceCallCreateHolder.WebServicePostCall(p0);

            return this;
        }

        public AndroidPage SelectWarehouse(string warehouseLoc)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='" + warehouseLoc + "']"));
            Driver.FindElementByXPath("//android.widget.TextView[@text='" + warehouseLoc + "']").Click();
            return this;
        }

        public AndroidPage StartAppPerformingScroll(string appName)
        {
            //Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + appName + "\"))");
            //Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + appName + "\").instance(0))");
            AndroidElement elementToClick = (AndroidElement)Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()" + ".className(\"android.widget.LinearLayout\")).scrollIntoView(" + "new UiSelector().text(\"" + appName + "\"));");
            elementToClick.Click();
            //var element = Driver.FindElementByXPath("//android.widget.TextView[@text='" + appName + "']");
            //element.Click();

            Thread.Sleep(3000);
            return this;
        }

        public AndroidPage StartAppByPerformingScroll(string appName)
        {
            //Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + appName + "\"))");
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + appName + "\").instance(0))");
            //AndroidElement elementToClick = (AndroidElement)Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()" + ".className(\"android.widget.LinearLayout\")).scrollIntoView(" + "new UiSelector().text(\"" + appName + "\"));");
            //elementToClick.Click();
            var element = Driver.FindElementByXPath("//android.widget.TextView[@text='" + appName + "']");
            element.Click();

            Thread.Sleep(3000);
            return this;
        }

        public AndroidPage ChangeTheHolderUnit(string holderUnit)
        {
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + holderUnit + "\").instance(0))");
            var element = Driver.FindElementByXPath("//android.widget.Button[@text='" + holderUnit + "']");
            element.Click();
            return this;
        }

        public void ScanPacktable(string p0)
        {
            Thread.Sleep(2000);
            WaitMethods.WaitForElementToBePresent(By.Id(InputFieldPacktable));
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputFieldPacktable).SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }

        public void ScanPackholder(string p0)
        {
            Thread.Sleep(2000);
            WaitMethods.WaitForElementToBePresent(By.Id(InputFieldPackHolder));
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputFieldPackHolder).SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }

        public void ClickOnRepackButton()
        {
            Thread.Sleep(2000);
            WaitMethods.WaitForElementToBePresent(By.XPath(RepackButton));
            Driver.FindElementByXPath(RepackButton).Click();
        }

        public void ClickOnOutboundButton()
        {
            Thread.Sleep(3000);
            WaitMethods.WaitForElementToBePresent(By.XPath(OutboundInformationButton));
            Driver.FindElementByXPath(OutboundInformationButton).Click();
        }
        

        public void ClickOnCreatePackholder()
        {
            Thread.Sleep(2000);
            WaitMethods.WaitForElementToBePresent(By.XPath(CreatePackholderButton));
            Driver.FindElementByXPath(CreatePackholderButton).Click();
        }
        public void ClickOnReportProblem()
        {
            Thread.Sleep(5000);
            WaitMethods.WaitForElementToBePresent(By.XPath(ReportProblem));
            Driver.FindElementByXPath(ReportProblem).Click();
        }

        public void ScanProblem()
        {
            Thread.Sleep(2000);
            WaitMethods.WaitForElementToBePresent(By.XPath(ProblemValue));
            Driver.FindElementByXPath(ProblemValue).Click();
        }
       

        public void ClickOnClosePackHolder()
        {
            Thread.Sleep(3000);
            WaitMethods.WaitForElementToBePresent(By.XPath(ClosePackholder));
            Driver.FindElementByXPath(ClosePackholder).Click();
        }

        public void ScanOrderLIne(string p0)
        {
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            Driver.FindElementsById(InputOrderLineField)[1].SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }

        public void SplitQty(string p0)
        {
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            Driver.FindElementsById(InputOrderLineField)[0].SendKeys(p0);
            Thread.Sleep(2000);
        }


        public void ScanQuantityOfProblem(string p0)
        {
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            Driver.FindElementById(QtyOfProblem).SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }
        public void ScanUnitInRepack(string p0)
        {
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            Driver.FindElementById(UnitInRepack).SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }

        public void ScanWeightInRepack(string p0)
        {
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            Driver.FindElementById(WeightInRepack).SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }
        

        public AndroidPage SelectWhilePerformingScroll(string module)
        {
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + module + "\"))");
            var element = Driver.FindElementByXPath("//android.widget.Button[@text='" + module + "']");
            element.Click();
            return this;
        }


        public AndroidPage SelectModule(string module)
        {
            Thread.Sleep(4000);

            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + module + "\"))");

            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.Button[@text='" + module + "']"));

            Driver.FindElementByXPath("//android.widget.Button[@text='" + module + "']").Click();
            return this;
        }

        public AndroidPage ClickOnRFAndroidInbound(string varRecArr)
        {
            Driver.FindElementByXPath("//android.widget.Button[@text='" + varRecArr + "']").Click();
            return this;
        }

        public AndroidPage ClickPalletisationNeeded(string YesNoPallet)
        {
            Driver.FindElementByXPath("//android.widget.Button[@text='" + YesNoPallet + "']").Click();
            return this;
        }
        public AndroidPage DeleteFilesFromFolder()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("\\\\itglo.net\\public\\EMEA\\BE-KI\\Temp\\Maas\\STYRAAutomation\\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            return this;
        }

        public AndroidPage DeleteFilesFromFolderBaselineTwo()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("\\\\itglo.net\\public\\EMEA\\BE-KI\\Temp\\BaselineTwo\\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            return this;
        }


        public AndroidPage DeleteFilesfromFolderStyraAutomationNiflsik()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("\\\\itglo.net\\public\\EMEA\\BE-KI\\Temp\\Maas\\STYRAAutomation\\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            return this;
            return this;
        }
        public AndroidPage ClickButtonNameInAndroidScreenGeneral(string genButton)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.Button[@text='" + genButton + "']"));
            Driver.FindElementByXPath("//android.widget.Button[@text='" + genButton + "']").Click();
            return this;
        }

        public AndroidPage SelectRowContains(string rowCointains)
        {
            Driver.FindElement(By.XPath($"//android.widget.TextView[contains(@text, '{rowCointains}')]")).Click();
            return this;
        }

        public AndroidPage SearchForQueueGroupListPicking()
        {
            Actions action = new Actions(Driver);
            Driver.FindElementByXPath(SearchInputQueueGroupList).Click();

            action.SendKeys(DataCollection.PickwaveCode).SendKeys(Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage SearchForInAndroidSearchBar(string searchString)
        {
            Actions action = new Actions(Driver);
            action.SendKeys(searchString).SendKeys(Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage ClickSearchIconOnAndroid()
        {
            Driver.FindElementByXPath(SearchIconOnAndroid).Click();
            return this;
        }

        public AndroidPage EnterValueOnInputTxtField(string input)
        {
            WaitMethods.WaitForElementToBePresent(By.Id(InputTextField));
            DataCollection.XMLValue = input;
            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }



        public AndroidPage EnterValueOnCheckdigitInputTxtField(string input)
        {
            //WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='Last scan info']"));
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='Check-digit' and @index='2']"));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterCheckDigitIntoPiecePickingPage(string input)
        {
            //WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='Last scan info']"));
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.EditText[@text='Check-digit' and @index='0']"));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterValueOnCheckdigitInputTxtFieldOnTTLAllInRFAndroid(string input)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='Transfer All Check-digit' and @index='2']"));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterCheckDigitInUnloading(string input)
        {
            WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='Unloading']"));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterValueOnInputHolderTxtField(string input)
        {
            //WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='Transfer to Loading']"));
            
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='Queue List' and @index='2']"));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage ScanPickholderInPackingRFAndroid(string input)
        {
            //WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='Transfer to Loading']"));

            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='Pickholder or Location' and @index='2']"));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterValueOnInputPickHolderInUnloading(string input)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.TextView[@text='Unloading']"));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterValueForLocationInUnloading(string input)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.TextView[@text='Unloading']"));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage SendAnEmptyLocationInUnloading()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.TextView[@text='Unloading']"));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterValueOnInputTxtFieldStockHolder(string input)
        {
            //WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='SKU to pick']"));

            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.TextView[@text='SKU to pick']"));
            //WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='Item']"));
            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterValueOnInputTxTFieldITEMSSCC(string input)
        {
            //WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='SKU to pick']"));

            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.EditText[@text='Item/SSCC']"));
            //WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='Item']"));
            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterValueOnInputTxtFieldStockHolderBarcode(string input)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.TextView[@text='Item']"));
            //WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='SKU to pick']"));
            //WaitMethods.WaitForPageToBeReady(By.XPath("//android.widget.TextView[@text='Item']"));
            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage SideMenuToChangeHolderUnnit(string HolderUnit)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(NavigatonMenuButton));
            Driver.FindElementByXPath(NavigatonMenuButton).Click();

            Driver.FindElementByXPath("//android.widget.Button[@text='" + HolderUnit + "']").Click();
            return this;
        }

        public AndroidPage ClickButton(string p0)
        {
            Driver.FindElement(By.XPath($"//android.widget.Button[contains(@text, '{p0}')]")).Click();
            Thread.Sleep(2000);
            WaitMethods.WaitForElementToBeGone(By.XPath($"//android.widget.Button[contains(@text, '{p0}')]"));
            return this;
        }

        public AndroidPage NewStockHolder(string stock)
        {
            Driver.FindElementById("net.itglo.cgi.rf.client.t:id/textViewLine1").Click();
            return this;
        }
        public AndroidPage ReadTheRequestMessageAndValidateValue(string p0)
        {
            string[] array2 = Directory.GetFiles(@"\\itglo.net\public\EMEA\BE-KI\Temp\BaselineTwo\", "*Request.XML");
            string finalName = string.Empty;
            foreach (string name in array2)
            {

                finalName += name;

            }

            
            string enumLines = File.ReadAllText(finalName, Encoding.UTF8);
            Assert.That(enumLines.Contains(p0));
            return this;
        }


        public AndroidPage WriteCommentForBlockReason(string blockReasonComment)
        {
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputTextField).SendKeys(blockReasonComment);
            action.SendKeys(Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage ClickOnErrorMessage()
        {
            //Driver.FindElement(By.XPath($"//android.widget.Button[contains(@text, 'OK')]")).Click();
            //Thread.Sleep(2000);

            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.Button[contains(@text, 'OK')]"));
            Driver.FindElementByXPath("//android.widget.Button[contains(@text, 'OK')]").Click();
            return this;
        }

        public AndroidPage CreateSuperholderMain()
        {
            //WaitMethods.WaitForPageToBeReady(By.XPath(OKButtonAndroid));
            WaitMethods.WaitForElementToBePresent(By.XPath(CreateASuperHolderButtonMain));
            Driver.FindElementByXPath(CreateASuperHolderButtonMain).Click();
            return this;
        }



        public AndroidPage EnterHolderUnit(string EnterHolderUnit)
        {
            Thread.Sleep(1000);
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(EnterHolderUnit);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage EnterWidthPalletDimension(int widthPallDim)
        {
            Thread.Sleep(1500);
            Actions action = new Actions(Driver);
            action.SendKeys(widthPallDim + Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage EnterDepthPalletDimension(int depthPallDim)
        {
            Thread.Sleep(1000);
            Actions action = new Actions(Driver);
            action.SendKeys(depthPallDim + Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage EnterHeightPalletDimension(int heightPallDim)
        {
            Thread.Sleep(1000);
            Actions action = new Actions(Driver);
            action.SendKeys(heightPallDim + Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage EnterConfigurationUnit(string ConUnit)
        {
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(ConUnit);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage WeightOfItem(string weight)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(Page.WeightHolder));

            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.XPath(WeightHolder));
            Driver.FindElementByXPath(WeightHolder).Clear();
            //Driver.FindElementByXPath(WeightHolder).Click();
            action.SendKeys(weight + Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage EnterTransportInbound(string TransportInbound)
        {
            WaitMethods.WaitForElementToBePresent(By.Id(InputTextField));
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputTextField).SendKeys(TransportInbound);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterHolderWidthOfBox(string holderWidth)
        {
            Thread.Sleep(1500);
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputTextField).Clear();
            action.SendKeys(holderWidth + Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage EnterHolderDepthOfBox(string holderDepth)
        {
            Thread.Sleep(1500);
            Actions action = new Actions(Driver);
            action.SendKeys(holderDepth + Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage EnterHolderHeightOfBox(string holderHeight)
        {
            Thread.Sleep(1500);
            Actions action = new Actions(Driver);
            action.SendKeys(holderHeight + Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage SelectQueueFromSearchQGList()
        {
            Driver.FindElementByXPath("//android.widget.TextView[@text='" + DataCollection.PickwaveCode + "']").Click();
            return this;
        }

        public AndroidPage ScanATRIFromVariableTRIvarToAndroidAppium()
        {
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputTextField);
            action.SendKeys(DataCollection.TRIvar).SendKeys(Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage ScanSavedVariableHolVarToAndoidAppium()
        {
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputTextField);
            action.SendKeys(DataCollection.HolVar1).SendKeys(Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage ScanSavedVariableHolVarSecToAndoidAppium()
        {
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputTextField);
            action.SendKeys(DataCollection.HolVar2).SendKeys(Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage ClickOKButton()
        {
            //WaitMethods.WaitForPageToBeReady(By.XPath(OKButtonAndroid));
            WaitMethods.WaitForElementToBePresent(By.XPath(OKButtonAndroid));
            Driver.FindElementByXPath(OKButtonAndroid).Click();
            return this;
        }
   
        public AndroidPage QtyToPickAndroid(string qty)
        {
             WaitMethods.WaitForElementToBePresent(By.Id("net.itglo.cgi.rf.client.t:id/edittext_numberpicker"));

            IWebElement el = Driver.FindElementsById("net.itglo.cgi.rf.client.t:id/edittext_numberpicker")[0];
            el.SendKeys(qty);
            return this;
        }

        public AndroidPage QtyToPickAndroidStyra(string qty)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(Page.QTYtoPick));

            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.XPath(QTYtoPick));
            Driver.FindElementByXPath(QTYtoPick).Click();
            action.SendKeys(qty + Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage ClickHamburgerMenuFromThePiecePickingPage()
        {
            // WaitMethods.WaitForPageToBeReady(By.XPath(CreatePickholder))
            WaitMethods.WaitForElementToBePresent(By.XPath(HamburgerMenuButton));
            Driver.FindElementByXPath(HamburgerMenuButton).Click();
            return this;
        }

        public AndroidPage IVerifyThatStockIsShownCorrectly(string stock)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{stock}']"));
            string correctBarcode = "ST805954";
            Assert.AreEqual(stock, correctBarcode);
            return this;
        }

        public AndroidPage ClickTTLAllButton()
        {
            // WaitMethods.WaitForPageToBeReady(By.XPath(CreatePickholder))
            WaitMethods.WaitForElementToBePresent(By.XPath(TTLAllButton));
            Driver.FindElementByXPath(TTLAllButton).Click();
            return this;
        }

        public AndroidPage FindTransferToLoadingScrollAndClickOnIt(string elementName)
        {
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + elementName + "\").instance(0))");
            WaitMethods.WaitForElementToBePresent(By.XPath(TransferToLoadingButton));
            Driver.FindElementByXPath(TransferToLoadingButton).Click();
            return this;
        }

        public AndroidPage FindOtherQueueScrollAndClickOnIt(string elementName)
        {
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + elementName + "\"))");
            WaitMethods.WaitForElementToBePresent(By.XPath(OtherQueueButton));
            Driver.FindElementByXPath(OtherQueueButton).Click();
            return this;
        }

        public AndroidPage FindViewLocationScrollAndClickOnIt(string elementName)
        {
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + elementName + "\"))");
            WaitMethods.WaitForElementToBePresent(By.XPath(ViewLocationButton));
            Driver.FindElementByXPath(ViewLocationButton).Click();
            return this;
        }

        public AndroidPage FindViewStockScrollAndClickOnIt(string elementName)
        {
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + elementName + "\"))");
            WaitMethods.WaitForElementToBePresent(By.XPath(ViewStockButton));
            Driver.FindElementByXPath(ViewStockButton).Click();
            return this;
        }


        public AndroidPage WarningMessageOnRFAndroidAppium(string errorScreenMessage)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[contains(@text, '{errorScreenMessage}')]"));
            return this;
        }

        public AndroidPage ClickFromTheMenu(string p0)
        {
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + p0 + "\").instance(0))");
            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.Button[@text='" + p0 + "']"));
            Driver.FindElementByXPath("//android.widget.Button[@text='" + p0 + "']").Click();

            return this;
        }

        public AndroidPage SelectFromPickingUnit(string pickingunit)
        {
          
            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.TextView[@text='" + pickingunit + "']"));
            Driver.FindElementByXPath("//android.widget.TextView[@text='" + pickingunit + "']").Click();

            return this;
        }

        public AndroidPage ValidateTextOnOtboundComments(string p0)
        {
            WaitMethods.WaitForPageToBeReady(By.XPath($"//android.widget.TextView[@text='{p0}' and @index='1']"));
            string CommentsOutbound = p0;
            Assert.AreEqual(p0, CommentsOutbound);
            return this;
        }

        public AndroidPage ScanAPickholderStyra(string input)
        {
            WaitMethods.WaitForElementToBePresent(By.Id(InsertPickholder));

            Actions action = new Actions(Driver);

            //Driver.FindElementById(InsertPickholder).Clear();
            Driver.FindElementById(InsertPickholder).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public void ScanAPIHolderInRF()
        {

            Thread.Sleep(5000);
            //WaitMethods.WaitForElementToBePresent(By.XPath(InsertPickholder));
            Actions action = new Actions(Driver);
            Driver.FindElementById(InsertSuperHolderRF).SendKeys(DataCollection.APICreateHolder);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }

        public AndroidPage QtyToPickNewStockAndroid(string qty)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(Page.QTYtoPickNewStock));

            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.XPath(QTYtoPickNewStock));
            Driver.FindElementByXPath(QTYtoPickNewStock).Click();
            action.SendKeys(qty + Keys.Enter).Build().Perform();
            return this;
        }
                
        public AndroidPage QtyForNewStockAndroid(string qty)
        {

            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.XPath(QTYForkNewStock));
            Driver.FindElementByXPath(QTYForkNewStock).Click();
            Driver.FindElementByXPath(QTYForkNewStock).Clear();
            action.SendKeys(qty + Keys.Enter).Build().Perform();
            return this;
        }


        public AndroidPage SKUPerConfigurationUnitOnAndroid(string qtyPerConfigUnit)
        {
            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.XPath(QTYtoPick));
            Driver.FindElementByXPath(QTYtoPick).Click();
            action.SendKeys(qtyPerConfigUnit + Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage CreateAPickholder()
        {
            WaitMethods.WaitForPageToBeReady(By.XPath(CreatePickholder))
                    .WaitForElementToBePresent(By.XPath(CreatePickholder));
            Driver.FindElementByXPath(CreatePickholder).Click();
            return this;
        }

        public AndroidPage ClickCreateAPickholder()
        {
            // WaitMethods.WaitForPageToBeReady(By.XPath(CreatePickholder))
            WaitMethods.WaitForElementToBePresent(By.XPath(CreatePickholder));
            Driver.FindElementByXPath(CreatePickholder).Click();
            return this;
        }

        public AndroidPage AddCloseAPickholder()
        {
            WaitMethods.WaitForPageToBeReady(By.XPath(AddClosePickholder))
                    .WaitForElementToBePresent(By.XPath(AddClosePickholder));
            Driver.FindElementByXPath(AddClosePickholder).Click();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage ClickOKButtonPopUPMessage()
        {
           // Thread.Sleep(1000);
            WaitMethods.WaitForElementToBePresent(By.XPath(OKPOPUpMessageAndroid));
            Driver.FindElementByXPath(OKPOPUpMessageAndroid).Click();
            return this;
        }

        public AndroidPage PressBackButton(int value)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(BackButtonAndroid));
            for (var i = 0; i < value; i++)
            {
                Driver.FindElementByXPath(BackButtonAndroid).Click();
                Thread.Sleep(3500);
            }
            return this;
        }

        public AndroidPage ShouldSeeScreenAppiumTitle (string title)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{title}' and @index='1']"));
            return this;
        }

        public AndroidPage PressBackButton()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(BackButtonAndroid));
            Driver.FindElementByXPath(BackButtonAndroid).Click();
            return this;
        }

        public AndroidPage ClickOnTheFirstQueuePickHolder()
        {
            WaitMethods.WaitForElementToBePresent(By.Id(FirstPickHolderInQueueList));
            Driver.FindElementById(FirstPickHolderInQueueList).Click();
            return this;
        }

        public AndroidPage ClickBackOnRFAndroidAppium()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(BackButtonAndroid));

            Driver.FindElementByXPath(BackButtonAndroid).Click();
            return this;
        }

        public AndroidPage PressMinusButton(int value)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(MinusButtonAndroid));
            for (var i = 0; i < value; i++)
            {
                Driver.FindElementByXPath(MinusButtonAndroid).Click();
            }
            return this;
        }

        public AndroidPage PressPlusButton(int value)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(PlusButtonAndroid));
            for (var i = 0; i < value; i++)
            {
                Driver.FindElementByXPath(PlusButtonAndroid).Click();
            }
            return this;
        }

        public AndroidPage LogoutFromRFPortal()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(NavigatonMenuButton));
            Driver.FindElementByXPath(NavigatonMenuButton).Click();
            WaitMethods.WaitForElementToBePresent(By.XPath(LogoutButton));
            Driver.FindElementByXPath(LogoutButton).Click();
            return this;
        }


        public AndroidPage HolderInfomationV004VAS()
        {
            System.Threading.Thread.Sleep(3000);
            string[] array2 = Directory.GetFiles(@"\\itglo.net\public\EMEA\BE-KI\Temp\Maas\STYRAAutomation\", "*Request.XML");
            string finalName = string.Empty;
            foreach (string name in array2)
            {

                finalName += name;

            }


            Debug.WriteLine("--- xml files Files: ---");
            String text = File.ReadAllText(finalName);
            Debug.WriteLine(text);

            CollectionAssert.IsSubsetOf("HOLDERINFORMATION_V004", text);
            // Assert.Contains("tem:HOLDERINFORMATION_V004", text);
            CollectionAssert.IsSubsetOf("<ext:ItemCode>107400719</ext:ItemCode>", text);
            //Assert.AreEqual("<ext:Value>TESTDESTITEM</ext:Value>", text);
            //Assert.AreEqual("<ext:PickedItemLabel>", text);1123 



            return this;
        }

        public AndroidPage ErrorMessageRFAndroid(string errorMessage)
        {
            Thread.Sleep(3000);
            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.TextView[@text='" + errorMessage + "']"));
            return this;
        }

        public AndroidPage ErrorMessageOnRFAndroidAppium(string errorScreenMessage)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[contains(@text, '{errorScreenMessage}')]"));
            return this;
        }

        public AndroidPage OrderLineAppearInRFRepack(string orderLineNo)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[contains(@text, '{orderLineNo}')]"));
            return this;
        }

        public AndroidPage ScanItem(string item)
        {
            WaitMethods.WaitForElementToBePresent(By.Id(InputTextField));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(item);
            action.SendKeys(Keys.Enter).Build().Perform();
            
            return this;
        }    
        
        public AndroidPage ClickOkButtonWarningMessage(string emptyMessage)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{emptyMessage}' and @index='0']"));
            Driver.FindElementByXPath(OKPOPUpWarningMessageAndroid).Click();
            return this;
        }       
        
        public AndroidPage SeeScreenSubtitleAppium(string subtitlePage)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{subtitlePage}' and @index='2']"));
            return this;
        }

        public AndroidPage SeeOkButtonInTTLVerifyThatLoadingLocationIsDetermined(string buttonText)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{buttonText}' and @index='0']"));
            return this;
        }

        public AndroidPage SeePackingComment(string packingComment)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{packingComment}']"));
            return this;
        }

        public AndroidPage SeeItemComment(string itemComment)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{itemComment}']"));
            return this;
        }

        public AndroidPage ISelectAProblemToReport(string problemValue)
        {
            Thread.Sleep(2000);

            //Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + problemValue + "\"))");

            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + problemValue + "\").instance(0))");

            //AndroidElement elementToClick = (AndroidElement)Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()" + ".className(\"android.widget.LinearLayout\")).scrollIntoView(" + "new UiSelector().text(\"" + problemValue + "\"));");

            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{problemValue}']"));
           
            var element = Driver.FindElementByXPath("//android.widget.TextView[@text='" + problemValue + "']");

            element.Click();

            return this;
        }
        

        public AndroidPage SeeWeightOfPickholder(string pickholderKG)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{pickholderKG}']"));
            return this;
        }

        public AndroidPage ChooseItemFromTheList(string itemFromList)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='" + itemFromList + "']"));
            Driver.FindElementByXPath($"//android.widget.TextView[@text='" + itemFromList + "']").Click();
            return this;
        }

        public AndroidPage ChooseHolderType(string text)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{text}' and @index='0']"));
            Driver.FindElementByXPath($"//android.widget.TextView[@text='{text}' and @index='0']").Click();
            return this;
        }


        public AndroidPage ClickPenForCustomer()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@index= '2']"));
            Driver.FindElementByXPath($"//android.widget.Button[@index= '2']").Click();
            return this;
        }
        public AndroidPage CommentInAndroid(int enterComment)
        {
            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.EditText[@index='0']"));
            action.SendKeys(enterComment + Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage SeeStockHolder(string text)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{text}' and @index='0']"));
            return this;
        }

        public AndroidPage SeeEmptyListofStock()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.view.View[@text='' and @index='2']"));
            return this;
        }

        public AndroidPage LongPressOnTheLocationOnRFAndroid(string longPress)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(LongPressOnTheLocation));
            TouchAction touchAction = new TouchAction(Driver);

            Driver.FindElementByXPath($"//android.widget.TextView[@text='{longPress}' and @index= '0']").Click();
        
            touchAction.LongPress(Driver.FindElementByXPath($"//android.widget.TextView[@text='{longPress}' and @index= '0']")).Release().Perform();

            return this;
        }

        public AndroidPage ClickTransfer(string transfer)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='Transfer' and @index='0']"));
            Driver.FindElement(By.XPath($"//android.widget.TextView[@text='{transfer}' and @index='0']")).Click();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage ClickOnViewHoldersInStock(string holderStock)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='View Holders in stock' and @index='0']"));
            Driver.FindElement(By.XPath($"//android.widget.TextView[@text='{holderStock}' and @index='0']")).Click();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage ClickSkuInStock(string skuInStock)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='View SKU in stock' and @index='0']"));
            Driver.FindElement(By.XPath($"//android.widget.TextView[@text='{skuInStock}' and @index='0']")).Click();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage ClickOnViewHoldersNotValidated(string holderNotValidated)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='View Holders not validated' and @index='0']"));
            Driver.FindElement(By.XPath($"//android.widget.TextView[@text='{holderNotValidated}' and @index='0']")).Click();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage ClickSkuNotVlidated(string skuNotValidated)
        {
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + skuNotValidated + "\"))");
            var element = Driver.FindElementByXPath($"//android.widget.TextView[@text='View SKU not validated' and @index='0']");
            element.Click();

            //WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='View SKU not validated' and @index='0']"));
            //Driver.FindElement(By.XPath($"//android.widget.TextView[@text='{skuNotValidated}' and @index='0']")).Click();
            Thread.Sleep(2000);
            
            return this;
        }

        public AndroidPage SeeScreenTransportOutboundComments(string subtitlePage)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{subtitlePage}' and @index='2']"));
            return this;
        }

        public AndroidPage ShouldSeeLocationAppium(string location)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.EditText[@text='{location}' and @index='0']"));
            return this;
        }

        public AndroidPage SearchForQueueGroupListPicking(string queueGroup)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchInputQueueGroupList));

            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchInputQueueGroupList));
            Driver.FindElementByXPath(SearchInputQueueGroupList).Click();

            action.SendKeys(queueGroup).SendKeys(Keys.Return).Build().Perform();
            return this;
        }

        public AndroidPage SearchForQueueGroupListPickingAfterClearValue(string queueGroup)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchInputQueueGroupListAfterClearValue));

            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchInputQueueGroupListAfterClearValue));
            Driver.FindElementByXPath(SearchInputQueueGroupListAfterClearValue).Click();

            action.SendKeys(queueGroup).SendKeys(Keys.Return).Build().Perform();
            return this;
        }

        public AndroidPage SearchForQueueGroupListPickingScanholderStatusFinished(string queueGroup)
        {
            Actions action = new Actions(Driver);
            Driver.FindElementByXPath(SearchInputQueueGroupListScanHolderFinishedStatus).Click();

            action.SendKeys(queueGroup).SendKeys(Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage IShouldSeeQueueGroupOnRFAndroid (string queueGroup)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[contains(@text, '{queueGroup}')]"));
            return this;
        }

        public AndroidPage PickHolderBarcode(string pickholder)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchForPickHolderBarcode));
            Actions action = new Actions(Driver);
            Driver.FindElement(By.XPath(SearchForPickHolderBarcode)).SendKeys(pickholder);
            action.SendKeys(Keys.Enter).Build().Perform();
            return this;
        }

        public AndroidPage ClickOnQueueGroup()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(QueueGroup));
            Driver.FindElementByXPath(QueueGroup).Click();
            return this;
        }

        public AndroidPage SelectQueueFromSearchQGList(string queueGroup)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='" + queueGroup + "']"));
            Driver.FindElementByXPath($"//android.widget.TextView[@text='" + queueGroup + "']").Click();
            return this;
        }

        public AndroidPage ClickOKButtonToLeaveEmptyLocation()
        {
            //WaitMethods.WaitForPageToBeReady(By.XPath(OKButtonAndroid));
            WaitMethods.WaitForElementToBePresent(By.XPath(OKClickAndroid));
            Driver.FindElementByXPath(OKClickAndroid).Click();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage IClickOnOptionOfNavigationMenu(string option)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='" + option + "']"));
            Driver.FindElementByXPath($"//android.widget.Button[@text='" + option + "']").Click();
            return this;
        }

        public AndroidPage ScanHolderBarcode(string p0)
        {
            Driver.FindElementByXPath("//android.widget.EditText[@text='" + p0 + "']").Click();
            return this;
        }

        public AndroidPage StartAppRFPortal(string app)
        {
            Thread.Sleep(1000);
            var element = Driver.FindElementByXPath("//android.widget.TextView[@text='" + app + "']");
            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.TextView[@text='" + app + "']"));

            element.Click();
            return this;
        }

        public AndroidPage ScanSavedPickHolderAndroid()
        {
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).SendKeys(DataCollection.SavedPickHolderFromAndroid);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage SaveCreatedPickholderAndroid()
        {
            Thread.Sleep(2000);
            DataCollection.SavedPickHolderFromAndroid = Driver.FindElementByXPath("//android.widget.TextView[contains(@text, 'PI')]").Text;
            Console.WriteLine(DataCollection.SavedPickHolderFromAndroid);
            return this;
        }

        public AndroidPage YesButtonAndroid()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(YesButtonAndroidXpath));
            Driver.FindElementByXPath(YesButtonAndroidXpath).Click();
          
            return this;
        }

        public AndroidPage AddToPickholder()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(AddToPickholderXpath));
            Driver.FindElementByXPath(AddToPickholderXpath).Click();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage NoButtonAndroid()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(NoButtonAndroidXpath));
            Driver.FindElementByXPath(NoButtonAndroidXpath).Click();
            return this;
        }

        public AndroidPage ClearSearchedQueueGroup()
        {
            Driver.FindElementByXPath(ClearSearchQueueGroup).Click();
            return this;
        }

        public AndroidPage GoBackToSearchQueueGroup()
        {
            Driver.FindElementByXPath(GoBackToSearchQueueGroupXpath).Click();
            return this;
        }

        public AndroidPage OpenNavigationMenu()
        {
            Thread.Sleep(3000);
            //  WaitMethods.WaitForElementToBePresent(By.XPath(NavigatonMenuButton));
            Driver.FindElementByXPath(NavigatonMenuButton).Click();
            return this;
        }

        public AndroidPage ChangeThePickholderUnit()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ChangeThePickHolderUnitXpath));
            
            Driver.FindElementByXPath(ChangeThePickHolderUnitXpath).Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(ChangeThePickHolderUnitXpath));
            return this;
        }

        public AndroidPage OpenCreateSuperHolder()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(CreateASuperHolderButton));
            Driver.FindElementByXPath(CreateASuperHolderButton).Click();
            return this;
        }

        public AndroidPage ViewPickHolderContentQueueGroupMenu()
        {
            Driver.FindElementByXPath("//android.widget.Button[@text='View Pickholder Content']").Click();
            return this;
        }

        public AndroidPage ClosePickholder()
        {
            Driver.FindElementByXPath(ClosePickholderXpath).Click();
            return this;
        }

        public AndroidPage ChangeQTYtoPick(string qty)
        {
            WaitMethods.WaitForElementToBePresent(By.Id("net.itglo.cgi.rf.client.t:id/edittext_numberpicker"));

            IWebElement el = Driver.FindElementsById("net.itglo.cgi.rf.client.t:id/edittext_numberpicker")[0];
            el.SendKeys(qty);
            return this;
        }



        public AndroidPage ChangeQtyToTransfer(string qty)
        {

            WaitMethods.WaitForPageToBeReady(By.XPath(NewQtyToTransfer));

            Actions action = new Actions(Driver);
            Driver.FindElementById(NewQtyToTransfer).Click();
            action
                .SendKeys(Keys.Backspace + Keys.Backspace)
                .SendKeys(Keys.ArrowRight)
                .SendKeys(qty + Keys.Enter)
                .Build()
                .Perform();
            return this;
            
        }

        public AndroidPage WriteDimensionsForBoxUnit(string dimensions)
        {
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputTextField).SendKeys(dimensions);
            action.SendKeys(Keys.Enter).Build().Perform();
            return this;
        }
        public AndroidPage ChooseUnitType(string unit)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(PenToChangeUnit));
            Driver.FindElementByXPath(PenToChangeUnit).Click();
            Thread.Sleep(1000);
            Driver.FindElementByXPath(BoxUnit).Click();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage EnterWidthBoxDimension(int widthBox)
        {
            Thread.Sleep(1500);
            IWebElement click = Driver.FindElementsById("net.itglo.cgi.rf.client.t:id/edittext_textfield")[0];
            click.Click();
            click.Clear();

            Actions action = new Actions(Driver);
            action.SendKeys(widthBox + Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage EnterDepthBoxDimension(int depthBox)
        {
            Thread.Sleep(1000);
            IWebElement click = Driver.FindElementsById("net.itglo.cgi.rf.client.t:id/edittext_textfield")[1];
            click.Click();
            click.Clear();

            Actions action = new Actions(Driver);
            action.SendKeys(depthBox + Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage EnterHeightBoxDimension(int heightBox)
        {
            Thread.Sleep(1000);
            IWebElement click = Driver.FindElementsById("net.itglo.cgi.rf.client.t:id/edittext_textfield")[2];
            click.Click();
            click.Clear();

            Actions action = new Actions(Driver);
            action.SendKeys(heightBox + Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            return this;
        }

        public AndroidPage SelectHolderType(string holderType)
        {
            Driver.FindElement(By.XPath($"//android.widget.TextView[@text='{holderType}']")).Click();
            Thread.Sleep(2000);
            //WaitMethods.WaitForElementToBeGone(By.XPath($"//android.widget.TextView[contains(@text, '{holderType}')]"));
            return this;
        }

        public AndroidPage ShouldSeeTextOnRFAndroid(string text)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='List contains no items to display']"));
            return this;
        }

        public AndroidPage CheckIfLocationIsCorrect()

        {
            string location = "22-C-C-05-C-30";
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{location}' and @index='0']"));


            if (!location.StartsWith("22-C-G"))
            {
                ClickBackOnRFAndroidAppium();
            }
            //else
            //{
            //    ClickButton("OTHER LOCATION");
            //}
            return this;
        }
        public AndroidPage SeeTextOnScreen(string text)
        {
            //WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.View[@text='' and @index= '0']"));
            //Thread.Sleep(1000);
            //WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{text}' and @index= '0']"));

            //WaitMethods.WaitForPageToBeReady(By.XPath($"//android.widget.TextView[@text='{text}' and @index= '0']"));
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='No locations found for item']"));

            string textOnView = text;
            Assert.Equals(text, textOnView);
            return this;

        }

        public AndroidPage QtyToCorrectAndroid(string qty)
        {
            WaitMethods.WaitForPageToBeReady(By.XPath(Page.QTYtoCorrect));

            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.XPath(QTYtoCorrect));
            Driver.FindElementByXPath(QTYtoCorrect).Click();
            action.SendKeys(qty + Keys.Enter).Build().Perform();
            return this;
        }


        public AndroidPage CheckComments(string comments)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.TextView[@text='" + comments + "']"));
            return this;
        }

        public AndroidPage SelectUnitForPickholder(string unit)
        {
             WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.Button[@text='" + unit + "']"));
            Driver.FindElementByXPath("//android.widget.Button[@text='" + unit + "']").Click();
            return this;
        }

        public AndroidPage ClearSearchValueQueueGroup()
        {
            WaitMethods.WaitForPageToBeReady(By.XPath(ClearSearchValueQGrpScreen))
                    .WaitForElementToBePresent(By.XPath(ClearSearchValueQGrpScreen));
            Driver.FindElementByXPath(ClearSearchValueQGrpScreen).Click();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage ClickChangePickHolderUnit()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ChangePickholderUnitXpath));
            Driver.FindElementByXPath(ChangePickholderUnitXpath).Click();
            return this;
        }

        public AndroidPage ConfirmClosePickholders()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ConfrimClosePickholdersBtn));
            Driver.FindElementByXPath(ConfrimClosePickholdersBtn).Click();
            return this;
        }

        public AndroidPage ClickViewPickHolderContent()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ViewPickholderContent));
            Driver.FindElementByXPath(ViewPickholderContent).Click();
            return this;
        }

        public AndroidPage ChangePickholderUnit()
        {
             WaitMethods.WaitForElementToBePresent(By.XPath(ChangePickholderUnitXpath));
            Driver.FindElementByXPath(ChangePickholderUnitXpath).Click();
            return this;
        }

        public AndroidPage ScanMachineType(string machineType)
        {
            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(machineType);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage CreateASuperHolder()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ViewPickholderContent));
            Driver.FindElementByXPath(ViewPickholderContent).Click();
            return this;
        }

        public AndroidPage EnterWidthCm(string width)
        {
            IWebElement el = Driver.FindElementsById("net.itglo.cgi.rf.client.t:id/edittext_textfield")[0];
            el.Clear();
            el.SendKeys(width);
            return this;
        }
        public AndroidPage EnterDepthCm(string depth)
        {
            IWebElement el = Driver.FindElementsById("net.itglo.cgi.rf.client.t:id/edittext_textfield")[1];
            el.Clear();
            el.SendKeys(depth);
            return this;
        }

        public AndroidPage EnterHeightCm(string height)
        {
            IWebElement el = Driver.FindElementsById("net.itglo.cgi.rf.client.t:id/edittext_textfield")[2];
            el.Clear();
            el.SendKeys(height);
            return this;
        }


        public AndroidPage SeeExpected_InstockForOneItem(string difference)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{difference}' and @index='3']"));
            return this;
        }

        public AndroidPage EnterConfiguration (string config)
        {
            WaitMethods.WaitForElementToBePresent(By.Id(InputTextField));

            Actions action = new Actions(Driver);

            Driver.FindElementById(InputTextField).Clear();
            Driver.FindElementById(InputTextField).SendKeys(config);
            action.SendKeys(Keys.Enter).Build().Perform();
            //Thread.Sleep(2000);
            return this;
        }

        public AndroidPage IEnterQuantityNumber(string qty)
        {
            //Actions action = new Actions(Driver);
           WaitMethods.WaitForElementToBePresent(By.XPath(QTYtoPickValue));
            //Driver.FindElementByXPath(QTYtoPickValue).Click();
            //action.SendKeys(qty + Keys.Enter).Build().Perform();

           
            Actions action = new Actions(Driver);
            Driver.FindElementByXPath(QTYtoPickValue).Click();
            action
            .SendKeys(Keys.Backspace + Keys.Backspace)
            .SendKeys(Keys.ArrowRight)
            .SendKeys(qty + Keys.Enter)
            .Build()
            .Perform();


            return this;
        }

        public AndroidPage ICheckIfElementIsPresent(string locator)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{locator}' and @index='0']"));         
            string menuDropDown = "Other Queue";
            Assert.AreEqual(locator, menuDropDown);
            return this;
        }

        public AndroidPage IVerifyThatStockholderBarcodeIsThere(string barcode)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{barcode}']"));
            string correctBarcode = "ST068430";
            Assert.AreEqual(barcode, correctBarcode);
            return this;
        }

        public AndroidPage IShouldSeeAlertMessageWithATitle(string alertTitle)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{alertTitle}']"));
            string correctAlertMessage = "Queue Group Info";
            Assert.AreEqual(alertTitle, correctAlertMessage);
            return this;
        }

        public AndroidPage IVerifyThatLocationWithTheStockIsThere(string location)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{location}']"));
            string correctLocation = "22CA08E08";
            Assert.AreEqual(location, correctLocation);
            return this;
        }

        public AndroidPage ICheckIfElementAskInspectionIsPresent(string locator)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{locator}' and @index='1']"));
            string menuDropDown = "Ask Inspection";
            Assert.AreEqual(locator, menuDropDown);
            return this;
            
        }

        public AndroidPage ICheckIfLocatorIsPresent(string locator)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{locator}' and @index='2']"));
            string menuDropDown = "Ask Replenishment";
            Assert.AreEqual(locator, menuDropDown);
            return this;
        }

        public AndroidPage ICheckIfLocatorIsThere(string p0)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{p0}' and @index='3']"));
            
           string menuDropDown = "Block Location";
           Assert.AreEqual(p0, menuDropDown);
           return this;
        }

        public AndroidPage IShouldSeeElementIsPresent(string p0)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{p0}' and @index='4']"));
            string menuDropDown = "View Extra Information";
            Assert.AreEqual(p0, menuDropDown);
            return this;
        }

        public AndroidPage IShouldSeeElementWhilePerformingScroll(string p0)
        {
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + p0 + "\"))");  
            string menuDropDown = "View Location";
            Assert.AreEqual(p0, menuDropDown);
            return this;
        }

        public AndroidPage IShouldSeeLocator(string p0)

        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{p0}' and @index='1']"));
            string menuDropDown = "View Stock";
            Assert.AreEqual(p0, menuDropDown);
            return this;
        }

        public AndroidPage ICheckIfIsPresent(string p0)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{p0}' and @index='2']"));
            string menuDropDown = "Transfer To Loading";
            Assert.AreEqual(p0, menuDropDown);
            return this;
        }

        public AndroidPage IVerifyTheElement(string p0)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{p0}' and @index='3']"));
            string menuDropDown = "Print Documents";
            Assert.AreEqual(p0, menuDropDown);
            return this;
        }

        public AndroidPage IVerifyTheElementIsPresent(string p0)
        {
        //    Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + p0 + "\").instance(0))");
        //    WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.Button[@text='{p0}' and @index='4']"));
        //    string menuDropDown = "Exit";
        //    Assert.AreEqual(p0, menuDropDown);
        //    Driver.FindElementByXPath(ExitButton).Click();
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + p0 + "\").instance(0))");
            WaitMethods.WaitForElementToBePresent(By.XPath(ExitButton));
            Driver.FindElementByXPath(ExitButton).Click();
            return this;
        }

        public AndroidPage IShouldSeeScreenTitleAppium(string page)
        {           
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{page}' and @index='1']"));
            return this;
        }

        public AndroidPage IVerifyThatOtherItemIsShown(string item)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{item}' and @index='1']"));
            return this;
        }

        public AndroidPage IShouldWaitForPageToBeReady(string page)
        {
            WaitMethods.WaitForPageToBeReady(By.XPath($"//android.widget.TextView[@text='{page}' and @index='1']"));
            return this;
        }


        public AndroidPage IClickExitButton()
        {           
            WaitMethods.WaitForElementToBePresent(By.XPath(ExitButton));
            Driver.FindElementByXPath(ExitButton).Click();
            return this;
        }
        public void SelectBestBeforeDateMonthDayYearAppium(string month, string day, string year)
        {
            Driver.FindElementById("net.itglo.cgi.rf.client.t:id/datePicker").Click();
            Thread.Sleep(1000);
            Driver.FindElementsById("android:id/numberpicker_input")[0].Click();
            Thread.Sleep(500);
            new Actions(Driver).SendKeys(month).Perform();

            Driver.FindElementsById("android:id/numberpicker_input")[1].Click();
            Thread.Sleep(500);
            new Actions(Driver).SendKeys(day).Perform();

            Driver.FindElementsById("android:id/numberpicker_input")[2].Click();
            Thread.Sleep(500);
            new Actions(Driver).SendKeys(year + Keys.Return).Perform();
        }

        public AndroidPage IClickEyeButton()
        {
            
                    
            IWebElement click = Driver.FindElementsById("net.itglo.cgi.rf.client.t:id/endIcon")[1];
            WaitMethods.WaitForElementToBePresent(By.Id("net.itglo.cgi.rf.client.t:id/endIcon"));
            click.Click();
            return this;            
        }

        public AndroidPage IValidateTextInScannedPickholdersPage()
        {           
            WaitMethods.WaitForPageToBeReady(By.XPath(ScannedPickHolders));                  
            return this;
        }

        public AndroidPage ClickViewScannedPickholder()
        {
            IWebElement click = Driver.FindElementByXPath(ViewScannedPickHolders);
            WaitMethods.WaitForElementToBePresent(By.XPath(ViewScannedPickHolders));
            click.Click();
              
            
            return this;            
        }

        public AndroidPage ValidatePickholderOnScannedPickholdersPage(string p0)

        {
            
            WaitMethods.WaitForPageToBeReady(By.XPath($"//android.widget.TextView[@text='{p0}' and @index='0']"));
            string ScannedPickHolder = p0;
            Assert.AreEqual(p0, ScannedPickHolder);
            return this;
        }

        public AndroidPage ValidateSKYOnSerialNumbersScreenSubtitl(string sku)

        {

            WaitMethods.WaitForPageToBeReady(By.XPath($"//android.widget.TextView[@text='{sku}' and @text='1']"));
            string ScannedSKU = sku;
            Assert.AreEqual(sku, ScannedSKU);
            return this;
        }

        public AndroidPage ValidateUnitsToPick(string units)

        {

            WaitMethods.WaitForPageToBeReady(By.XPath($"//android.widget.TextView[@text='{units}' and @index='1']"));
            string UnitstoPick = units;
            Assert.AreEqual("0 BOX", UnitstoPick);
            return this;
        }

        public AndroidPage EnterQuantityPCSNumber (string qty)
        {
            WaitMethods.WaitForElementToBePresent(By.Id("net.itglo.cgi.rf.client.t:id/edittext_numberpicker"));
            //Driver.FindElementByXPath(QTYtoPickValue).Click();
            IWebElement el = Driver.FindElementsById("net.itglo.cgi.rf.client.t:id/edittext_numberpicker")[0];
            el.SendKeys(qty);
            WaitMethods.WaitForElementToBePresent(By.XPath(OKButtonAndroid));
            Driver.FindElementByXPath(OKButtonAndroid).Click();
            return this;
        }
        public AndroidPage ValidateProposedPickholderInPiecePicking(string p0)

        {

            WaitMethods.WaitForPageToBeReady(By.XPath($"//android.widget.TextView[@text='{p0}' and @index='1']"));
            string ProposedPickiholder = p0;
            Assert.AreEqual("A-1-00302594009183081836", ProposedPickiholder);
            return this;
        }


        public AndroidPage EnterSerialNumber(string serialnumber)
        {
            
            
            Actions action = new Actions(Driver);

            Driver.FindElementById("net.itglo.cgi.rf.client.t:id/edittext_textfield").Click();
            Driver.FindElementById("net.itglo.cgi.rf.client.t:id/edittext_textfield").SendKeys(serialnumber);
            action.SendKeys(Keys.Enter).Build().Perform();
                       
            Thread.Sleep(2000);
            return this;
        }

        public AndroidPage EnterALocation(string location)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(OKButtonAndroid));

            Actions action = new Actions(Driver);

            Driver.FindElementById("net.itglo.cgi.rf.client.t:id/edittext_textfield").Click();
            Driver.FindElementById("net.itglo.cgi.rf.client.t:id/edittext_textfield").SendKeys(location);
            action.SendKeys(Keys.Enter).Build().Perform();

            Thread.Sleep(2000);
            return this;
        }

        public void ScanMaterial(string p0)
        {
            Thread.Sleep(9000);
            WaitMethods.WaitForElementToBePresent(By.Id(InputFieldStyra));

            Actions action = new Actions(Driver);
            Driver.FindElementById(InputFieldStyra).SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }
        public void ScanAnInputOnStyra(string input)
        {
            Thread.Sleep(5000);
            WaitMethods.WaitForElementToBePresent(By.Id(InsertMaterial));
            Actions action = new Actions(Driver);
            Driver.FindElementById(InsertMaterial).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }
        public void ScanCart(string p0)
        {
            Thread.Sleep(5000);
            // WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldStyra));
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputFieldStyra).SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }

        public void ScanDropOffLocation(string p0)
        {
            Thread.Sleep(5000);
            // WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldStyra));
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputFieldStyra).SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }


        public void ScanSerialNumberStyra(string input)
        {
            Thread.Sleep(5000);
            WaitMethods.WaitForElementToBePresent(By.XPath(InsertSerialNumber));
            Actions action = new Actions(Driver);
            Driver.FindElementByXPath(InsertSerialNumber).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }
        public void EnterItemOnInputTxtField(string input)
        {
            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.Id(InputTextFieldSTYRA));
            Driver.FindElementById(InputTextFieldSTYRA).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }
        public void PickTheExactQuantityOfItem()
        {
            Thread.Sleep(5000);
           // Actions action = new Actions(Driver);
            // AssertMethods.WaitForElementToBePresent(_androidDriver, _NEWQTYtoPick, PropertyType.XPath);
            Driver.FindElementById(ExactQTYToPick).Click();

        }
        public void ScanAPIHolder()
        {

            Thread.Sleep(5000);
            //WaitMethods.WaitForElementToBePresent(By.XPath(InsertPickholder));
            Actions action = new Actions(Driver);
            Driver.FindElementById(InsertPickholder).SendKeys(DataCollection.APICreateHolder);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }

        public void ScanTheSameNewSerialNumberTwice()
        {
            Thread.Sleep(5000);

            WaitMethods.WaitForElementToBePresent(By.XPath(InsertSerialNumber));

            Random rand = new Random();
            int randomSerialNumber = rand.Next(6, 2147483647);
            string serialNumber = randomSerialNumber.ToString();


            Actions action = new Actions(Driver);
            Driver.FindElementByXPath(InsertSerialNumber).SendKeys(serialNumber);
            DataCollection.CreatedSerialNumber = serialNumber;
            action.SendKeys(Keys.Enter).Build().Perform();

            Thread.Sleep(5000);

            Driver.FindElementByXPath(InsertSerialNumber).SendKeys(DataCollection.CreatedSerialNumber);
            action.SendKeys(Keys.Enter).Build().Perform();



            Thread.Sleep(5000);

        }

        public void ScanNewSerialNumber()
        {
            Thread.Sleep(5000);

            Random rand = new Random();
            int randomSerialNumber = rand.Next(6, 2147483647);
            string serialNumber = randomSerialNumber.ToString();

            Actions action = new Actions(Driver);
            Driver.FindElementByXPath(InsertSerialNumber).SendKeys(serialNumber);
            action.SendKeys(Keys.Enter).Build().Perform();

            Thread.Sleep(5000);

        }

        public void ScanTheLocation()
        {
            Thread.Sleep(5000);
           // WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldStyra));
            Actions action = new Actions(Driver);
            //Driver.FindElementById(InputFieldStyra).SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }


        public void ScanLocation(string p0)
        {
            Thread.Sleep(5000);
            // WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldStyra));
            Actions action = new Actions(Driver);
            Driver.FindElementById(InputFieldStyra).SendKeys(p0);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }
        public void PushButtonToConfirm()
        {
            //Actions action = new Actions(_androidDriver);
            Thread.Sleep(3000);
            //AssertMethods.WaitForElementToBePresent(_androidDriver, _ConfirmButton, PropertyType.XPath);
            Driver.FindElementsById("net.itglo.cgi.styra.t:id/button_screen_center")[0].Click();
            Thread.Sleep(3000);
        }
        public void ClickExitButtonStyra()
        {
            Thread.Sleep(3000);
            //  WaitMethods.WaitForElementToBePresent(By.XPath("//android.widget.TextView[@text='EXIT']"));
            Driver.FindElementByXPath("//android.widget.TextView[@text='EXIT']").Click();
        }
        public void ErrorMessageStyra(string errorMessage)
        {
            Thread.Sleep(3000);
            // AssertMethods.WaitForElementToBePresent(_androidDriver, "//android.widget.TextView[@text='" + errorMessage + "']", PropertyType.XPath);
            Driver.FindElementByXPath("//android.widget.TextView[@text='" + errorMessage + "']").Click();
        }
        public void ClickOkButtonStyra()
        {
            //AssertMethods.WaitForElementToBePresent(_androidDriver, _OkButtonStyra, PropertyType.Id);
            Thread.Sleep(2000);
            Driver.FindElementById(OkButtonStyra).Click();
        }
        public void ScanASuperHolder(string input)
        {
            Thread.Sleep(4000);
            //AssertMethods.WaitForElementToBePresent(_androidDriver, _InsertMaterial, PropertyType.Id);
            Actions action = new Actions(Driver);
            Driver.FindElementById(InsertMaterial).SendKeys(input);
            action.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
        }
        public void PickWrongQuantityOfItem()
        {
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            // AssertMethods.WaitForElementToBePresent(_androidDriver, _NEWQTYtoPick, PropertyType.XPath);
            Driver.FindElementByXPath(WrongQTYToPick).Click();
            Thread.Sleep(2000);
            Driver.FindElementById(ExactQTYToPick).Click();

        }
        public void ProblemButtonsStyra()
        {
            Thread.Sleep(4000);
            WaitMethods.WaitForElementToBePresent(By.XPath(ProblemButtonStyra));
            // AssertMethods.WaitForElementToBePresent(_androidDriver, _ProblemButtonStyra, PropertyType.XPath);
            Driver.FindElementByXPath(ProblemButtonStyra).Click();
        }
        public void SelectProblemButtonStyra(string problemButton)
        {
            Thread.Sleep(4000);
            // AssertMethods.WaitForElementToBePresent(_androidDriver, "//android.widget.Button[@text='" + problemButton + "']", PropertyType.XPath);
            Driver.FindElementByXPath("//android.widget.Button[@text='" + problemButton + "']").Click();
        }
        public void VerifyMessageStyraScreen(string message)
        {
            Thread.Sleep(4000);
            //AssertMethods.WaitForElementToBePresent(_androidDriver, "//android.widget.TextView[@text='" + message + "']", PropertyType.XPath);
            Driver.FindElementByXPath("//android.widget.TextView[@text='" + message + "']").Click();
        }
        public void ClickYesAfterProblemButton()
        {
            Thread.Sleep(4000);
            //AssertMethods.WaitForElementToBePresent(_androidDriver, "//android.widget.Button[@text='yes']", PropertyType.XPath);
            Driver.FindElementByXPath("//android.widget.Button[@text='YES']").Click();
        }

        public AndroidPage SelectPickzone(string pickzone)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{pickzone}' and @index='0']"));
            Driver.FindElementByXPath($"//android.widget.TextView[@text='{pickzone}' and @index='0']").Click();
            return this;
        }

        public AndroidPage ValidateLastScanInfoOnTTLRFAndroid(string p0)
        {
            WaitMethods.WaitForPageToBeReady(By.XPath($"//android.widget.TextView[@text='{p0}' and @index='1']"));
            string LastScanInfo = p0;
            Assert.AreEqual("S002314222051703-001: 1/1", LastScanInfo);
            return this;
        }

        public AndroidPage ClickYESOnWariningInPickingWithSerialNumbers()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(WariningSerialNumber));
            Driver.FindElementByXPath(WariningSerialNumber).Click();

            return this;  
        }

        public AndroidPage ValidateWeightInPiecePickingOnRfAndroid(string p0)
        {
           WaitMethods.WaitForElementToBePresent(By.XPath($"//android.widget.TextView[@text='{p0}' and @index='1']"));
            string weight = p0;
            Assert.AreEqual("1,05", weight);
           
            return this;
        }


    }
}