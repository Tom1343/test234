using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Drawing;
using TechTalk.SpecFlow;

namespace CGI_OUTBOUND_Android_Scenarios.Utilities
{
    [Binding]
    public class Page
    {
        internal AndroidDriver<AppiumWebElement> Driver;

        public Page(AndroidDriver<AppiumWebElement> driver) => Driver = driver;

        public const string InputBadgeNumberId = "login_view_badge_number";

        public const string SearchInputQueueGroupList = "//android.widget.TextView[@content-desc='Search']";

        public const string SearchInputQueueGroupListAfterClearValue = "//android.widget.EditText[@text='   Search for ...']";

        public const string SearchInputQueueGroupListScanHolderFinishedStatus = "//android.widget.TextView[@content-desc='TRI-010157-20210709-22CA22A01']";

        public const string SearchIconOnAndroid = "//android.widget.TextView[@content-desc='Search']";

        public const string InputFieldPacktable = "net.itglo.cgi.rf.client.t:id/edittext_textfield";

        public const string InputFieldPackHolder = "net.itglo.cgi.rf.client.t:id/edittext_textfield";

        public const string RepackButton = "//android.widget.Button[@text='REPACK']";

        public const string OutboundInformationButton = "//android.widget.TextView[@text='PICKED']";

        public const string CreatePackholderButton = "//android.widget.Button[@text='CREATE PACKHOLDER']";

        public const string ReportProblem = "//android.widget.Button[@text='REPORT PROBLEM']";

        public const string ProblemValue = "//android.widget.TextView[@text='GEZIM TEST']";

        public const string ClosePackholder = "//android.widget.Button[@text='CLOSE PACKHOLDER']";

        public const string InputOrderLineField = "net.itglo.cgi.rf.client.t:id/edittext_textfield";

        public const string QtyOfProblem = "net.itglo.cgi.rf.client.t:id/edittext_textfield";

        public const string UnitInRepack = "net.itglo.cgi.rf.client.t:id/edittext_textfield";

        public const string WeightInRepack = "net.itglo.cgi.rf.client.t:id/edittext_textfield";

        public const string InputTextSearchQueueGroupList = "//android.widget.EditText[@text='Search for ...']";

        public const string InputTextField = "net.itglo.cgi.rf.client.t:id/edittext_textfield";

        public const string FirstPickHolderInQueueList = "net.itglo.cgi.rf.client.t:id/rowLayout";

        public const string InputStockHolderBarcode = "//android.widget.EditText[@index='0']";

        public const string OKButtonAndroid = "//android.widget.Button[@text='OK']";

        public const string OKClickAndroid = "//android.widget.Button[@text='OK']";

        public const string WeightHolder = "//android.widget.EditText[@text='36']";

        public const string PlusButtonAndroid = "//android.widget.Button[@text='+']";

        public const string MinusButtonAndroid = "//android.widget.Button[@text='-']";

        public const string QTYtoPick = "//android.widget.EditText[@text='0']";

        public const string SearchForPickHolderBarcode = "//android.widget.EditText[@index='0']";

        public const string QTYtoPickValue = "//android.widget.EditText[@index='1']";

        public const string QTYtoPickNewStock = "//android.widget.EditText[@text='5']"; 
        
        public const string QTYForkNewStock = "//android.widget.EditText[@text='0']";

        public const string QTYtoCorrect = "//android.widget.EditText[@text='100']";

        public const string CreatePickholder = "//android.widget.Button[@text='CREATE PICKHOLDER']";

        public const string AddClosePickholder = "//android.widget.Button[@text='ADD & CLOSE PICKHOLDER']";

        public const string AddToPickholderXpath = "//android.widget.Button[@text='ADD TO PICKHOLDER']";

        public const string OKPOPUpMessageAndroid = "//android.widget.Button[@text='OK']";
        
        public const string OKPOPUpWarningMessageAndroid = "//android.widget.Button[@text='OK']";

        public const string BackButtonAndroid = "//android.widget.TextView[@text='BACK']";

        public const string NavigatonMenuButton = "//android.widget.ImageButton[@content-desc='Open navigation drawer']";

        public const string ChangeThePickHolderUnitXpath = "//android.widget.Button[@text='Change Pickholder Unit']";

        public const string LogoutButton = "//android.widget.Button[@text='LOGOUT']";

        public const string ChangePickholderUnitXpath = "//android.widget.Button[@text='Change Pickholder Unit']";

        public const string ViewPickholderContent = "//android.widget.Button[@text='View Pickholder Content']";

        public const string ClosePickholderXpath = "//android.widget.Button[@text='CLOSE PICKHOLDER']";

        public const string ClearSearchValueQGrpScreen = "//android.widget.ImageView[@content-desc='Clear query']";

        public const string ConfrimClosePickholdersBtn = "//android.widget.Button[@text='CONFIRM & CLOSE PICKHOLDERS']";

        public const string YesButtonAndroidXpath = "//android.widget.Button[@text='YES']";

        public const string NoButtonAndroidXpath = "//android.widget.Button[@text='NO']";

        public const string GoBackToSearchQueueGroupXpath = "//android.widget.ImageButton[@content-desc='Collapse']";

        public const string NEWQTYtoPick = "net.itglo.cgi.rf.client.t:id/edittext_numberpicker"; 
        
        public const string NewQtyToTransfer = "net.itglo.cgi.rf.client.t:id/edittext_numberpicker"; 
        
        public const string PenToChangeUnit = "//android.widget.Button[@index= '2']";
       
        public const string BoxUnit = "//android.widget.Button[@text='BOX']";

        public const string ClearSearchQueueGroup = "//android.widget.ImageView[@content-desc='Clear query']";

        public const string QueueGroup = "//android.widget.TextView.[@index= '1']";

        public const string CreateASuperHolderButton = "//android.widget.Button[@text='Create Superholder']";

        public const string ExitButton = "//android.widget.Button[@text='Exit']";

        public const string ShouldSeeTextOnRFAndroid = "//android.widget.TextView[@text='List contains no items to display']";

        public const string ScannedPickHolders = "//android.widget.TextView[@index= '0']";

        public const string LongPressOnTheLocation = "//android.widget.TextView[@index= '0']";

        public const string TransferOnViewStock = "//android.widget.TextView[@text='Transfer']";

        public const string ViewScannedPickHolders = "//android.widget.Button[@text='View Scanned Pickholders']";

        public const string CreateASuperHolderButtonMain = "//android.widget.Button[@text='CREATE SUPERHOLDER']";

        public const string HamburgerMenuButton = "//android.widget.ImageButton[@content-desc='Open navigation drawer']";

        public const string TTLAllButton = "//android.widget.Button[@text='TTL ALL']";

        public const string TransferToLoadingButton = "//android.widget.Button[@text='Transfer To Loading']";

        public const string OtherQueueButton = "//android.widget.Button[@text='Other Queue']";

        public const string ViewLocationButton = "//android.widget.Button[@text='View Location']";

        public const string ViewStockButton = "//android.widget.Button[@text='View Stock']";

        public const string InsertSuperHolderRF = "net.itglo.cgi.rf.client.t:id/edittext_textfield";

        public const string InsertSerialNumber = "//android.widget.EditText[@text='SCAN SERIAL NUMBER']";

        public const string WariningSerialNumber = "//android.widget.Button[@text='YES']";


        //InputFieldStyra
        public const string InputFieldStyra = "net.itglo.cgi.styra.t:id/edittext_input";
        public const string InsertMaterial = "net.itglo.cgi.styra.t:id/edittext_input";
        public const string InputTextFieldSTYRA = "net.itglo.cgi.styra.t:id/edittext_input";
        public const string ExactQTYToPick = "net.itglo.cgi.styra.t:id/textview_center";
        public const string InsertPickholder = "net.itglo.cgi.styra.t:id/edittext_input";
        public const string OkButtonStyra = "net.itglo.cgi.styra.t:id/button_screen_center";
       // public const string InsertMaterial = "net.itglo.cgi.styra.t:id/edittext_input";
        public const string WrongQTYToPick = "(//android.widget.ImageButton[@index='0'])[2]";
        //public const string ExactQTYToPick = "net.itglo.cgi.styra.t:id/textview_center";
        public const string ProblemButtonStyra = "//android.widget.TextView[@content-desc='PROBLEM']";








        public void ScrollBetweenElements(IWebElement element1, IWebElement element2)
        {
            new TouchAction(Driver)
                .LongPress(element1.Location.X, element1.Location.Y)
                .MoveTo(element2.Location.X, element2.Location.Y)
                .Release()
                .Perform();
        }

        public void ScrollToElement(string locator)
        {
            Size dimensions = Driver.Manage().Window.Size;

            while (Driver.FindElements(By.XPath(locator)).Count == 0)
            {
                new TouchAction(Driver)
                    .LongPress((int)(dimensions.Width * 0.6), (int)(dimensions.Height * 0.5))
                    .MoveTo((int)(dimensions.Width * 0.1), (int)(dimensions.Height * 0.5))
                    .Release()
                    .Perform();
            }
        }
    }
}
