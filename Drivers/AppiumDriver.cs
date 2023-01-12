using BoDi;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGI_OUTBOUND_Android_Scenarios.Drivers
{

    public class AppiumDriver
    {
        public AndroidDriver<AppiumWebElement> Driver { get; set; }


        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            //Local run
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            driverOptions.AddAdditionalCapability("appActivity", "crc6434aedc4197d7f44b.BootScreen");
            driverOptions.AddAdditionalCapability("appWaitActivity", "crc6434aedc4197d7f44b.BootScreen, crc64a2c581207787cc09.LoginActivity");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Users\naumoskt\Desktop\Rf Folder\net.itglo.cgi.rf.portal.t.apk");
            // driverOptions.AddAdditionalCapability(MobileCapabilityType.App, ConfigurationManager.AppSettings.Get("RFPortalPath"));



            return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:30303/wd/hub"), driverOptions);


            //////Remote run
            //var driverOptions = new AppiumOptions();
            //driverOptions.AddAdditionalCapability("deviceName", "Genymotion Device image");
            //driverOptions.AddAdditionalCapability("uuid", "localhost:1234");
            //driverOptions.AddAdditionalCapability("browserName", "Browser");
            //driverOptions.AddAdditionalCapability("NoReset", "true");
            //driverOptions.AddAdditionalCapability("FullReset", "false");

            //return new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:1234/wd/hub"), driverOptions);



        }

    }
}
