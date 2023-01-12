using CGI_OUTBOUND_Android_Scenarios.Pages;
using CGI_OUTBOUND_Android_Scenarios.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace CGI_OUTBOUND_Android_Scenarios.Steps
{
    [Binding]
    public class AndroidSteps
    {
        //public AndroidDriver<AndroidElement> Driver;
        //private AndroidPage AndroidPage => new AndroidPage(Driver);
        //public AndroidSteps(AndroidDriver<AndroidElement> driver) => Driver = driver;

        private readonly ScenarioContext _scenarioContext;
        public AndroidSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        private AndroidPage AndroidPage => new AndroidPage(_scenarioContext.Get<AndroidDriver<AppiumWebElement>>());

        [Given(@"I login with user '(.*)' on RFAndroid and I start app '(.*)' on warehouse '(.*)'")]
        public void GivenILoginWithUserOnRFAndroidAndIStartAppOnWarehouse(string badgeNumber, string appName, string warehouseLoc)
        {
            AndroidPage.LoginAndStartAppFromWarehouse(badgeNumber, appName, warehouseLoc);
        }

        [Given(@"I select '(.*)' module on RFAndroid")]
        [When(@"I select '(.*)' module on RFAndroid")]
        [Then(@"I select '(.*)' module on RFAndroid")]
        public void GivenISelectModuleOnRFAndroid(string module)
        {
            AndroidPage.SelectModule(module);
        }
        [Given(@"I Delete Files from Folder")]
        public void GivenIDeleteFilesFromFolder()
        {
            AndroidPage.DeleteFilesFromFolder();
        }

        [Given(@"I Delete Files from Folder BaselineTwo")]
        public void GivenIDeleteFilesFromFolderBaselineTwo()
        {
            AndroidPage.DeleteFilesFromFolderBaselineTwo();
        }


        [Given(@"I Delete Files from Folder NilfiskBE")]
        public void GivenIDeleteFilesFromFolderNilfiskBE()
        {
            AndroidPage.DeleteFilesfromFolderStyraAutomationNiflsik();
        }

        [Given(@"I click '(.*)' on RFAndroid Inbound")]
        public void GivenIClickOnRFAndroidInbound(string varRecArr)
        {
            AndroidPage.ClickOnRFAndroidInbound(varRecArr);
        }

        [Given(@"I click '(.*)' palletisation needed")]
        public void GivenIClickPalletisationNeeded(string YesNoPallet)
        {
            AndroidPage.ClickPalletisationNeeded(YesNoPallet);
        }

        [Given(@"I click button name '(.*)' in Android screen general")]
        public void GivenIClickButtonNameInAndroidScreenGeneral(string genButton)
        {
            AndroidPage.ClickButtonNameInAndroidScreenGeneral(genButton);
        }

        [Given(@"I select row contains '(.*)'")]
        public void GivenISelectRowContains(string rowCointains)
        {
            AndroidPage.SelectRowContains(rowCointains);
        }

        [Given(@"I search for queue group on QueueGroup List on RFAndroid")]
        public void GivenISearchForQueueGroupOnQueueGroupListOnRFAndroid()
        {
            AndroidPage.SearchForQueueGroupListPicking();
        }

        [Given(@"I search for '(.*)' in Android search bar")]
        public void GivenISearchForInAndroidSearchBar(string searchString)
        {
            AndroidPage.SearchForInAndroidSearchBar(searchString);
        }

        [Given(@"I click search icon on Android")]
        public void GivenIClickSearchIconOnAndroid()
        {
            AndroidPage.ClickSearchIconOnAndroid();
        }


        [Given(@"I scan an input on textfield \(item,holderbarcode\) '(.*)' on RFAndroid"), When(@"I scan an input on textfield \(item,holderbarcode\) '(.*)' on RFAndroid"), Then(@"I scan an input on textfield \(item,holderbarcode\) '(.*)' on RFAndroid")]
        public void GivenIScanAnInputOnTextfieldItemHolderbarcodeOnRFAndroid(string input)
        {
            AndroidPage.EnterValueOnInputTxtField(input);
        }

        [Given(@"I scan an input on checkdigit textfield \(item,holderbarcode\) '(.*)' on RFAndroid"), When(@"I scan an input on checkdigit textfield \(item,holderbarcode\) '(.*)' on RFAndroid"), Then(@"I scan an input on checkdigit textfield \(item,holderbarcode\) '(.*)' on RFAndroid")]
        public void GivenIScanAnInputOnCheckdigitTextfieldItemHolderbarcodeOnRFAndroid(string input)
        {
            AndroidPage.EnterValueOnCheckdigitInputTxtField(input);
        }
        
        [Given(@"I scan check digit '(.*)' into check digit page in Piece picking"), When(@"I scan check digit '(.*)' into check digit page in Piece picking"), Then(@"I scan check digit '(.*)' into check digit page in Piece picking")]
        public void GivenIScanCheckDigitIntoCheckDigitPageInPiecePicking(string input)
        {
            AndroidPage.EnterCheckDigitIntoPiecePickingPage(input);
        }

        [Given(@"I scan an input on checkdigit textfield in TTL all '(.*)' on RFAndroid"), When(@"I scan an input on checkdigit textfield in TTL all '(.*)' on RFAndroid")]
        public void GivenIScanAnInputOnCheckdigitTextfieldInTTLallInRFAndroid(string input)
        {
            AndroidPage.EnterValueOnCheckdigitInputTxtFieldOnTTLAllInRFAndroid(input);
        }

        [Given(@"I scan an input on checkdigit in Unloading \(item,holderbarcode\) '(.*)' on RFAndroid"), When(@"I scan an input on checkdigit in Unloading \(item,holderbarcode\) '(.*)' on RFAndroid"), Then(@"I scan an input on checkdigit in Unloading \(item,holderbarcode\) '(.*)' on RFAndroid")]
        public void GivenIEnterCheckDigitInUnloading(string input)
        {
            AndroidPage.EnterCheckDigitInUnloading(input);
        }

        [Given(@"I scan an input on holder textfield \(item,holderbarcode\) '(.*)' on RFAndroid"), When(@"I scan an input on holder textfield \(item,holderbarcode\) '(.*)' on RFAndroid")]
        public void GivenIScanAnInputOnHolderTextfieldItemHolderbarcodeOnRFAndroid(string input)
        {
            AndroidPage.EnterValueOnInputHolderTxtField(input);
        }

        [Given(@"I scan pickholder in Packing '(.*)' on RFAndroid"), When(@"I scan pickholder in Packing '(.*)' on RFAndroid"), Then(@"I scan pickholder in Packing '(.*)' on RFAndroid")]
        public void GivenIScanPickholderInPackingONRFAndroid(string input)
        {
            AndroidPage.ScanPickholderInPackingRFAndroid(input);
        }

        [Given(@"I scan an input on pick holder textfield \(item,holderbarcode\) '(.*)' on RFAndroid"), When(@"I scan an input on pick holder textfield \(item,holderbarcode\) '(.*)' on RFAndroid"), Then(@"I scan an input on pick holder textfield \(item,holderbarcode\) '(.*)' on RFAndroid")]
        public void GivenIScanAnInputOnPickHolderTextfieldItemHolderbarcodeOnRFAndroid(string input)
        {
            AndroidPage.EnterValueOnInputPickHolderInUnloading(input);
        }

        [Given(@"I scan '(.*)' as a location in unloading on RFAndroid"), When(@"I scan '(.*)' as a location in unloading on RFAndroid"), Then(@"I scan '(.*)' as a location in unloading on RFAndroid")]
        public void GivenIScanALocationInUnloading(string input)
        {
            AndroidPage.EnterValueForLocationInUnloading(input);
        }

        [Given(@"I send an empty location in Unloading"), When(@"I send an empty location in Unloading")]
        public void GivenIScanAnEmptyLocationInUnloading()
        {
            AndroidPage.SendAnEmptyLocationInUnloading();
        }

        [Given(@"I scan an input on textfield \(item,stockholder\) '(.*)' on RFAndroid"), When(@"I scan an input on textfield \(item,stockholder\) '(.*)' on RFAndroid"), Then(@"I scan an input on textfield \(item,stockholder\) '(.*)' on RFAndroid")]
        public void GivenIScanAnInputOnTextfieldScanHolderbarcodeOnRFAndroid(string input)
        {
            AndroidPage.EnterValueOnInputTxtFieldStockHolder(input);
        }

        [Given(@"I scan an input on textfield for item/sscc '(.*)' on RFAndroid"), When(@"I scan an input on textfield for item/sscc '(.*)' on RFAndroid"), Then(@"I scan an input on textfield for item/sscc '(.*)' on RFAndroid")]
        public void GivenIScanAnInputOnTextfieldForItemSSCCOnRFAndroid(string input)
        {
            AndroidPage.EnterValueOnInputTxTFieldITEMSSCC(input);
        }

        [Given(@"I scan an input on textfield for stockholder barcode \(item,stockholderbarcode\) '(.*)' on RFAndroid"), When(@"I scan an input on textfield for stockholder barcode \(item,stockholderbarcode\) '(.*)' on RFAndroid"), Then(@"I scan an input on textfield for stockholder barcode \(item,stockholderbarcode\) '(.*)' on RFAndroid")]
        public void GivenIScanAnInputOnTextfieldItemScanHolderbarcodeOnRFAndroid(string input)
        {
            AndroidPage.EnterValueOnInputTxtFieldStockHolderBarcode(input);
        }

        [Given(@"I click side menu in RFClient '(.*)'")]
        public void GivenIClickSideMenuInRFClient(string HolderUnit)
        {
            AndroidPage.SideMenuToChangeHolderUnnit(HolderUnit);
        }

        [Given(@"I write comment '(.*)' for Block  Reason")]
        public void GivenIWriteCommentForBlockReason(string blockReasonComment)
        {
            AndroidPage.WriteCommentForBlockReason(blockReasonComment);
        }


        [Given(@"I enter Holder Unit '(.*)'")]
        public void GivenIEnterHolderUnit(string HolUnit)
        {
            AndroidPage.EnterHolderUnit(HolUnit);
        }

        [Given(@"I enter width '(.*)' Pallet Dimension")]
        public void GivenIEnterWidthPalletDimension(int widthPallDim)
        {
            AndroidPage.EnterWidthPalletDimension(widthPallDim);
        }

        [Given(@"I enter depth '(.*)' Pallet Dimension")]
        public void GivenIEnterDepthPalletDimension(int depthPallDim)
        {
            AndroidPage.EnterDepthPalletDimension(depthPallDim);
        }

        [Given(@"I enter height '(.*)' Pallet Dimension")]
        public void GivenIEnterHeightPalletDimension(int heightPallDim)
        {
            AndroidPage.EnterHeightPalletDimension(heightPallDim);
        }


        [Given(@"I enter Configuration Unit '(.*)'")]
        public void GivenIEnterConfigurationUnit(string ConUnit)
        {
            AndroidPage.EnterConfigurationUnit(ConUnit);
        }

        [Given(@"I enter Transport Inbound '(.*)'")]
        public void GivenIEnterTransportInbound(string TransportInbound)
        {
            AndroidPage.EnterTransportInbound(TransportInbound);
        }

        [Given(@"I scan a TRI from Variable TRIvar to android appium")]
        public void GivenIScanATRIFromVariableTRIvarToAndroidAppium()
        {
            AndroidPage.ScanATRIFromVariableTRIvarToAndroidAppium();
        }

        [Given(@"I scan saved variable HolVar to andoid appium")]
        public void GivenIScanSavedVariableHolVarToAndoidAppium()
        {
            AndroidPage.ScanSavedVariableHolVarToAndoidAppium();
        }

        [Given(@"I scan saved variable HolVarSec to andoid appium")]
        public void GivenIScanSavedVariableHolVarSecToAndoidAppium()
        {
            AndroidPage.ScanSavedVariableHolVarSecToAndoidAppium();
        }

        [Given(@"I select queue group from the list on RFAndroid")]
        public void GivenISelectQueueGroupFromTheListOnRFAndroid()
        {
            AndroidPage.SelectQueueFromSearchQGList();
        }

        [Given(@"I click OK button on Android")]
        [When(@"I click OK button on Android")]
        [Then(@"I click OK button on Android")]
        public void GivenIClickOKButtonOnAndroid()
        {
            AndroidPage.ClickOKButton();
        }

        [Given(@"I enter qty to pick '(.*)' on qtypicker input on Android"), When(@"I enter qty to pick '(.*)' on qtypicker input on Android")]
        public void GivenIEnterQtyToPickOnQtypickerInputOnAndroid(string qty)
        {
            AndroidPage.QtyToPickAndroid(qty);
            AndroidPage.ClickOKButton();
        }


        [Given(@"I enter qty to pick '(.*)' on qtypicker input New Stock on Android"), When(@"I enter qty to pick '(.*)' on qtypicker input New Stock on Android")]
        public void GivenIEnterQtyToPickOnQtypickerInputOnNewStockAndroid(string qty)
        {
            AndroidPage.QtyToPickNewStockAndroid(qty);
            AndroidPage.ClickOKButton();
        }

        [Given(@"I enter qty to '(.*)' on New Stock")]
        public void GivenIEnterQtyToOnNewStock(string qty)
        {
            AndroidPage.QtyForNewStockAndroid(qty);
            AndroidPage.ClickOKButton();
        }


        [Given(@"I enter qty to correct '(.*)' on qtypicker input on Android"), When(@"I enter qty to correct '(.*)' on qtypicker input on Android")]
        public void GivenIEnterQtyToCorrectOnQtypickerInputOnAndroid(string qty)
        {
            AndroidPage.QtyToCorrectAndroid(qty);
            AndroidPage.ClickOKButton();
        }

        [Given(@"I enter SKU per Configuration Unit '(.*)' on Android")]
        public void GivenIEnterSKUPerConfigurationUnitOnAndroid(string qtyPerConfigUnit)
        {
            AndroidPage.SKUPerConfigurationUnitOnAndroid(qtyPerConfigUnit);
            AndroidPage.ClickOKButton();
        }


        [Given, When, Then(@"I create a new pickholder on RFAndroid")]
        public void GivenICreateANewPickholderOnRFAndroid()
        {
            AndroidPage.CreateAPickholder();
        }

        [Given(@"I Add&Close to pickholder on RFAndroid")]
        public void GivenIAddCloseToPickholderOnRFAndroid()
        {
            AndroidPage.AddCloseAPickholder();
        }

        [Given(@"I press ok button to close popup message on RFAndroid")]
        public void GivenIPressOkButtonToClosePopupMessageOnRFAndroid()
        {
            AndroidPage.ClickOKButtonPopUPMessage();
        }

        [Given(@"I press back button (\d+) times"), Then(@"I press back button (\d+) times"), When(@"I press back button (\d+) times")]
        public void GivenIGoPressBackButtonTimes(int value)
        {
            AndroidPage.PressBackButton(value);

        }

        [Given(@"I click Back on RFAndroid appium"), When(@"I click Back on RFAndroid appium"), Then(@"I click Back on RFAndroid appium")]
        public void GivenIClickBackOnRFAndroidAppium()
        {
            AndroidPage.ClickBackOnRFAndroidAppium();
        }

        [Given(@"I should see screen '(.*)' appium title")]
        public void GivenIShouldSeeScreenAppiumTitle(string title)
        {
            AndroidPage.ShouldSeeScreenAppiumTitle(title);
        }

        [Given(@"I press \+ button (\d+) times on RFAndroid"), Then(@"I press \+ button (\d+) times on RFAndroid")]
        public void GivenIPressButtonTimesOnRFAndroid(int value)
        {
            AndroidPage.PressPlusButton(value);
            AndroidPage.ClickOKButton();
        }


        [Given(@"I press - button (\d+) times on RFAndroid")]
        public void GivenIPress_ButtonTimes(int value)
        {
            AndroidPage.PressMinusButton(value);
            AndroidPage.ClickOKButton();
        }

        [Given(@"I logout from RFPortal"), When(@"I logout from RFPortal"), Then(@"I logout from RFPortal")]
        public void GivenILogoutFromRFPortal()
        {
            AndroidPage.LogoutFromRFPortal();
        }

        [When(@"I read and validate the request message Nilfisk HOLDERINFOV004 VAS")]
        public void WhenIReadAndValidateTheRequestMessageNilfiskHOLDERINFOV004VAS()
        {
            AndroidPage.HolderInfomationV004VAS();
        }


        [Given(@"I should get an error message '(.*)' on RFAndroid")]
        public void GivenIShouldGetAnErrorMessageOnRFAndroid(string errorMessage)
        {
            AndroidPage.ErrorMessageRFAndroid(errorMessage);
            AndroidPage.ClickOKButtonPopUPMessage();
        }
        [Given(@"I should get an error message '(.*)' on RFAndroid for Putaway")]
        public void GivenIShouldGetAnErrorMessageOnRFAndroidForPutaway(string errorMessage)
        {
            AndroidPage.ErrorMessageOnRFAndroidAppium(errorMessage);
            AndroidPage.ClickOKButtonPopUPMessage();
        }



        [Given(@"I should get an error message '(.*)' on RFAndroid appium")]
        public void GivenIShouldGetAnErrorMessageOnRFAndroidAppium(string errorScreenMessage)
        {
            AndroidPage.ErrorMessageOnRFAndroidAppium(errorScreenMessage);
            AndroidPage.ClickOKButtonPopUPMessage();
        }

        [Then(@"I get an error message '(.*)' on RFAndroid appium")]
        public void WhenIGetAnErrorMessageOnRFAndroidAppium(string errorScreenMessage)
        {
            AndroidPage.ErrorMessageOnRFAndroidAppium(errorScreenMessage);
            AndroidPage.ClickOKButtonPopUPMessage();
        }

        [Given(@"I scan an item '(.*)'")]
        public void GivenIScanAnItem(string item)
        {
            AndroidPage.ScanItem(item);
        }

        [Given(@"I click '(.*)' on popup warning message")]
        public void GivenIClickOnPopupWarningMessage(string emptyMessage)
        {
            AndroidPage.ClickOkButtonWarningMessage(emptyMessage);
        }


        [Given(@"I should see screen subtitle '(.*)' appium"), When(@"I should see screen subtitle '(.*)' appium"), Then(@"I should see screen subtitle '(.*)' appium")]
        public void GivenIShouldSeeScreenSubtitleAppium(string subtitlePage)
        {
            AndroidPage.SeeScreenSubtitleAppium(subtitlePage);
        }


        [Given(@"I should see button '(.*)' for determined location"), When(@"I should see button '(.*)' for determined location"), Then(@"I should see button '(.*)' for determined location")]
        public void GivenIShouldVerifyLoadingLocationDeterminedByOKButton(string buttonText)
        {
            AndroidPage.SeeOkButtonInTTLVerifyThatLoadingLocationIsDetermined(buttonText);
        }

        [Given(@"I should see '(.*)' as a packing comment"), When(@"I should see '(.*)' as a packing comment"), Then(@"I should see '(.*)' as a packing comment")]
        public void GivenIShouldSeePackingComment(string packingComment)
        {
            AndroidPage.SeePackingComment(packingComment);
        }

        [Given(@"I should see '(.*)' as a item comment"), When(@"I should see '(.*)' as a item comment"), Then(@"I should see '(.*)' as a item comment")]
        public void GivenIShouldSeeItemComment(string itemComment)
        {
            AndroidPage.SeeItemComment(itemComment);
        }

        [Given(@"I select '(.*)' as a problem to report"), When(@"I select '(.*)' as a problem to report"), Then(@"I select '(.*)' as a problem to report")]
        public void GivenISelectAsAProblemToReport(string problemValue)
        {
            AndroidPage.ISelectAProblemToReport(problemValue);
        }

        [Given(@"I should see pickholder that has a weight of '(.*)'"), When(@"I should see pickholder that has a weight of '(.*)'"), Then(@"I should see pickholder that has a weight of '(.*)'")]
        public void GivenIShouldSeePickholderWithWeight(string pickholderKG)
        {
            AndroidPage.SeeWeightOfPickholder(pickholderKG);
        }

        [Given(@"I choose item '(.*)' from the list on RFAndroid")]
        public void GivenIChooseItemFromTheListOnRFAndroid(string itemFromList)
        {
            AndroidPage.ChooseItemFromTheList(itemFromList);
        }


        [Given(@"I choose holder type '(.*)'")]
        public void GivenIChooseHolderType(string text)
        {
            AndroidPage.ChooseHolderType(text);
        }


        [Given(@"I click on the pen to change the customer")]
        public void GivenIClickOnThePenToChangeTheCustomer()
        {
            AndroidPage.ClickPenForCustomer();
        }


        [Given(@"I should check if location is a correct one appium")]
        public void GivenIShouldCheckIfLocationIsACorrectOneAppium()
        {
            AndroidPage.CheckIfLocationIsCorrect();
        }


        [Given(@"I write comment '(.*)' in RF Andorid")]
        public void GivenIWriteCommentInRFAndorid(int enterComment)
        {
            AndroidPage.CommentInAndroid(enterComment);
        }

        [Given(@"I change qunatity to transfer '(.*)'")]
        public void GivenIChangeQunatityToTransfer(string qty)
        {
            AndroidPage.ChangeQtyToTransfer(qty);
            AndroidPage.ClickOKButton();
        }

        [Given(@"I choose unit '(.*)'")]
        public void GivenIChooseUnit(string unit)
        {
            AndroidPage.ChooseUnitType(unit);
        }

        [Given(@"I write Width '(.*)'")]
        public void GivenIWriteWidth(int width)
        {
            AndroidPage.EnterWidthBoxDimension(width);
        }

        [Given(@"I write Depth '(.*)'")]
        public void GivenIWriteDepth(int depth)
        {
            AndroidPage.EnterDepthBoxDimension(depth);
        }

        [Given(@"I write Height '(.*)'")]
        public void GivenIWriteHeight(int height)
        {
            AndroidPage.EnterHeightBoxDimension(height);
        }

        [Given(@"I select type '(.*)' in RFAndroid")]
        public void GivenISelectTypeInRFAndroid(string holderType)
        {
            AndroidPage.SelectHolderType(holderType);
        }

        [Given(@"I should see stockholder '(.*)' on RFAndroid")]
        public void GivenIShouldSeeStockholderOnRFAndroid(string text)
        {
            AndroidPage.SeeStockHolder(text);
        }


        [Given(@"I should see text '(.*)' on RFAndroid screen")]
        public void GivenIShouldSeeTextOnRFAndroidScreen(string text)
        {
            AndroidPage.SeeTextOnScreen(text);
        }


        [Given(@"I should see empty list of Stock")]
        public void GivenIShouldSeeEmptyListOfStock()
        {
            AndroidPage.SeeEmptyListofStock();
        }

        [Given(@"I long press on the location '(.*)' on RFAndroid")]
        public void GivenILongPressOnTheLocationOnRFAndroid(string longPress)
        {
            AndroidPage.LongPressOnTheLocationOnRFAndroid(longPress);
        }

        [Given(@"I click '(.*)' from menu appium")]
        public void GivenIClickFromMenuAppium(string holderNotValidated)
        {
            AndroidPage.ClickOnViewHoldersNotValidated(holderNotValidated);
        }


        [Given(@"I click '(.*)' from menu")]
        public void GivenIClickFromMenu(string holderStock)
        {
            AndroidPage.ClickOnViewHoldersInStock(holderStock);
        }

        [Given(@"I click '(.*)' appium")]
        public void GivenIClickAppium(string skuInStock)
        {
            AndroidPage.ClickSkuInStock(skuInStock);
        }

        [Given(@"I click '(.*)' scrolling on appium")]
        public void GivenIClickScrollingOnAppium(string skuNotValidated)
        {
            AndroidPage.ClickSkuNotVlidated(skuNotValidated);
        }

        [Given(@"I click '(.*)'")]
        public void GivenIClick(string transfer)
        {
            AndroidPage.ClickTransfer(transfer);
        }


        [Given(@"I should see transport outbound screen subtitle '(.*)' appium"), When(@"I should see transport outbound screen subtitle '(.*)' appium")]
        public void GivenIShouldSeeTransportOutboundCommentAppium(string subtitlePage)
        {
            AndroidPage.SeeScreenTransportOutboundComments(subtitlePage);
        }

        [Given(@"I should see location '(.*)' appium")]
        public void GivenIShouldSeeLocationAppium(string location)
        {
            AndroidPage.ShouldSeeLocationAppium(location);
        }


        [Given(@"I Send the QueueGroups with filename '(.*)'"), When(@"I Send the QueueGroups with filename '(.*)'"), Then(@"I Send the QueueGroups with filename '(.*)'")]
        public void GivenISendTheQueueGroupsWithFilename(string fileName)
        {
            AndroidPage.SendInstructionToQueueGroup(fileName);
        }

        [Given(@"I Send the QueueGroups with filename '([^']*)' to BaselineTwo"), When(@"I Send the QueueGroups with filename '([^']*)' to BaselineTwo"), Then(@"I Send the QueueGroups with filename '([^']*)' to BaselineTwo")]
        public void GivenISendTheQueueGroupsWithFilenameToBaselineTwo(string fileName)
        {
            AndroidPage.SendInstructionToQueueGroupBaselineTwo(fileName);
        }

        [Given(@"I Send the QueueGroups in Styra with filename '(.*)'"), When(@"I Send the QueueGroups in Styra with filename '(.*)'"), Then(@"I Send the QueueGroups in Styra with filename '(.*)'")]
        public void GivenISendTheQueueGroupsinStyraWithFilename(string fileName)
        {
            AndroidPage.SendInstructionToQueueGroupBaselineTwo(fileName);
        }

        [Given(@"I Send the QueueGroups in Styra with filename '(.*)' to create holder"), When(@"I Send the QueueGroups in Styra with filename '(.*)' to create holder"), Then(@"I Send the QueueGroups in Styra with filename '(.*)' to create holder")]
        public void GivenISendTheQueueGroupsInStyraToCreateHolder(string fileName)
        {
            AndroidPage.SendInstructionToCreateHolderBaselineTwo(fileName);
        }

        [Given(@"I search for queue group '(.*)' on QueueGroup List on RFAndroid")]
        public void GivenISearchForQueueGroupOnQueueGroupListOnRFAndroid(string queueGroup)
        {
            AndroidPage.SearchForQueueGroupListPicking(queueGroup);
        }

        [Given(@"I should see queue group '(.*)' on RFAndroid")]
        public void GivenIShouldSeeQueueGroupOnRFAndroid(string queueGroup)
        {
            AndroidPage.IShouldSeeQueueGroupOnRFAndroid(queueGroup);
        }

        [Given(@"I search for queue group '(.*)' on QueueGroup List with finished status on RFAndroid")]
        public void GivenISearchForQueueGroupOnQueueGroupListOnRFAndroidScanHolderStatusFinished(string queueGroup)
        {
            AndroidPage.SearchForQueueGroupListPickingScanholderStatusFinished(queueGroup);
        }

        [Given(@"I select queue group '(.*)' from the list on RFAndroid"), When(@"I select queue group '(.*)' from the list on RFAndroid")]
        public void GivenISelectQueueGroupFromTheListOnRFAndroid(string queueGroup)
        {
            AndroidPage.SelectQueueFromSearchQGList(queueGroup);
        }

        [Given(@"I click on '(.*)' from the navigation menu"), When(@"I click on '(.*)' from the navigation menu")]
        public void GivenIClickOnOptionOfNavigationMenu(string option)
        {
            AndroidPage.IClickOnOptionOfNavigationMenu(option);
        }

        [When(@"I select '(.*)' unit for pickholder on RFAndroid")]
        public void GivenISelectUnitForPickholderOnRFAndroid(string unit)
        {
           
            AndroidPage.SelectUnitForPickholder(unit);
        }

        [Given(@"I Add to pickholder on RFAndroid")]
        public void GivenIAddToPickholderOnRFAndroid()
        {
            AndroidPage.AddToPickholder();
        }

        [Given(@"I clear searched queue group on RFAndroid")]
        public void GivenIClearSearchedQueueGroupOnRFAndroid()
        {
            AndroidPage.ClearSearchValueQueueGroup();
        }


        [Given(@"I close pickholder from queue group screen")]
        public void GivenIClosePickholderFromQueueGroupScreen()
        {
            AndroidPage.OpenNavigationMenu();
            AndroidPage.ClickViewPickHolderContent();
            AndroidPage.ClosePickholder();
        }

        [Given(@"I close pickholder in packing")]
        [When(@"I close pickholder in packing")]
        [Then(@"I close pickholder in packing")]
        public void GivenIClosePickholderInPacking()
        {
            AndroidPage.ClosePickholder();
        }

        [Given(@"I change qty to pick '(.*)'")]
        public void GivenIChangeQtyToPick(string qty)
        {
            AndroidPage.ChangeQTYtoPick(qty);
            AndroidPage.ClickOKButton();
        }

        [Given(@"I change pickholder unit '(.*)' via navigation menu on RFAndroid")]
        public void GivenIChangePickholderUnitViaNavigationMenuOnRFAndroid(string unit)
        {
            AndroidPage.OpenNavigationMenu();
            AndroidPage.ChangePickholderUnit();
            AndroidPage.SelectUnitForPickholder(unit);
        }
        
        //test new steps
        [Given(@"I search and select queuegroup '(.*)' on queuegroup list")]
        public void GivenISearchAndSelectQueuegroupOnQueuegroupList(string queueGroup)
        {
            AndroidPage.SearchForQueueGroupListPicking(queueGroup);
            AndroidPage.SelectQueueFromSearchQGList(queueGroup);
        }


        [Given(@"I click ok to leave empty location")]
        public void GivenIClickOkToLeaveEmptyLocation()
        {
            AndroidPage.ClickOKButtonToLeaveEmptyLocation();
        }

        [Given(@"I click ok to continue work")]
        public void GivenIClickOkToContinueWork()
        {
            AndroidPage.ClickOKButton();
        }

        [When(@"I pick item '(.*)' with qty '(.*)'")]
        public void GivenIPickItemWithQty(string input, string qty)
        {
            AndroidPage.EnterValueOnInputTxtField(input);
            AndroidPage.QtyToPickAndroid(qty);
            AndroidPage.ClickOKButton();
        }

        [When(@"I pick an item with '(.*)' qty")]
        public void WhenIPickAnItemWithQty(string qty)
        {
            AndroidPage.QtyToPickAndroid(qty);
            AndroidPage.ClickOKButton();
        }


        [Then(@"I get an error message '(.*)'")]
        public void ThenIGetAnErrorMessage(string errorMessage)
        {
            AndroidPage.ErrorMessageRFAndroid(errorMessage);
            AndroidPage.ClickOKButtonPopUPMessage();
        }


        [When(@"I create, select unit '(.*)', add and close a pickholder")]
        public void ThenICreateSelectUnitAddAndCloseAPickholder(string unit)
        {
            AndroidPage.CreateAPickholder();
            AndroidPage.SelectUnitForPickholder(unit);
            AndroidPage.AddCloseAPickholder();
        }


        [Given(@"I enter pickholder barcode '(.*)'"), When(@"I enter pickholder barcode '(.*)'")]
        public void WhenIEnterPickHolderBarcode(string pickholder)
        {
            AndroidPage.PickHolderBarcode(pickholder);
        }

        [Then(@"I go back (.*) times and logout from RFAndroid"), When(@"I go back (.*) times and logout from RFAndroid")]
        public void ThenIGoBackTimesAndLogoutFromRFAndroid(int value)
        {
            AndroidPage.PressBackButton(value);
            AndroidPage.LogoutFromRFPortal();
        }

        [Then(@"I clear search value and go back (.*) times and logout from RFAndroid")]
        public void ThenIClearSearchValueAndGoBackTimesAndLogoutFromRFAndroid(int value)
        {
            AndroidPage.GoBackToSearchQueueGroup();
            AndroidPage.PressBackButton(value);
            AndroidPage.LogoutFromRFPortal();
        }

        [Given(@"I go back to queuegroup list on RFPicking"), Then(@"I go back to queuegroup list on RFPicking"), When(@"I go back to queuegroup list on RFPicking")]
        public void ThenIGoBackToQueuegroupListOnRFPicking()
        {
            AndroidPage.PressBackButton();
            AndroidPage.ClearSearchValueQueueGroup();
            AndroidPage.PressBackButton();
        }

        [Given(@"I clear search value in queuegroup list"), Then(@"I clear search value in queuegroup list"), When(@"I clear search value in queuegroup list")]
        public void IClearSearchValueInQueueGroupList()
        {
            AndroidPage.ClearSearchValueQueueGroup();
        }

        [Given(@"I click on the first pickholder of the queue list"), Then(@"I click on the first pickholder of the queue list"), When(@"I click on the first pickholder of the queue list")]
        public void ThenIClickOnTheFirstPickholderOfTheQueueList()
        {
            AndroidPage.ClickOnTheFirstQueuePickHolder();
        }


        [When(@"I go back to queuegroup list on RFPicking with one back")]
        public void WhenIGoBackToQueuegroupListOnRFPickingWithOneBack()
        {
           
            AndroidPage.PressBackButton();
        }



        [When(@"I change qty to pick '(.*)'")]
        public void ThenIChangeQtyToPick(string qty)
        {
            AndroidPage.ChangeQTYtoPick(qty);
            AndroidPage.ClickOKButton();
        }


        [Given(@"I send queuegroups '(.*)' and launch them '(.*)'")]
        public void GivenISendQueuegroupsAndLaunchThem(string fileToSend, string fileToLaunch)
        {
            AndroidPage.SendInstructionToQueueGroup(fileToSend);
            AndroidPage.SendInstructionToQueueGroup(fileToLaunch);
        }

        [Given(@"I send queuegroups '([^']*)' and launch them '([^']*)' in Nilfisk")]
        public void GivenISendQueuegroupsAndLaunchThemInNilfisk(string fileToSend, string fileToLaunch)
        {
            AndroidPage.SendInstructionToQueueGroupNilfisk(fileToSend);
            AndroidPage.SendInstructionToQueueGroupNilfisk(fileToLaunch);
        }

        [Given(@"I send queuegroups '([^']*)' and launch them '([^']*)' in Skatepro")]
        public void GivenISendQueuegroupsAndLaunchThemInSkatepro(string fileToSend, string fileToLaunch)
        {
            AndroidPage.SendInstructionToQueueGroupSkatepro(fileToSend);
            AndroidPage.SendInstructionToQueueGroupSkatepro(fileToLaunch);
        }

        [Given(@"I send queuegroups '([^']*)' and launch them '([^']*)' in Adeo")]
        public void GivenISendQueuegroupsAndLaunchThemInAdeo(string fileToSend, string fileToLaunch)
        {
            AndroidPage.SendQueuegroupsAndLaunchThemInAdeo(fileToSend);
            AndroidPage.SendQueuegroupsAndLaunchThemInAdeo(fileToLaunch);
        }


        [Given(@"I Send the QueueGroups with filename '([^']*)' Nilfsik")]
        [When(@"I Send the QueueGroups with filename '([^']*)' Nilfsik")]
        public void GivenISendTheQueueGroupsWithFilenameNilfsik(string fileToSend)
        {
            AndroidPage.SendInstructionToQueueGroupNilfisk(fileToSend);
        }
        [Given(@"Remove WCS091 Line '([^']*)' to be able to generate same massage")]
        public void GivenRemoveWCSLineToBeAbleToGenerateSameMassage( string fileToSend)
        {
            AndroidPage.SendInstructionToQueueGroupNilfisk(fileToSend);
        }


        [Given(@"I Send the QueueGroups with filename '([^']*)' Nilfsik Launch")]
        public void GivenISendTheQueueGroupsWithFilenameNilfsikLaunch(string fileToSend)
        {
            System.Threading.Thread.Sleep(13000);
            AndroidPage.LaunchInstructionToQueueGroupNilfisk(fileToSend);
        }


        [Given(@"I send queuegroups in Styra '(.*)' and launch them '(.*)'")]
        [When(@"I send queuegroups in Styra '(.*)' and launch them '(.*)'")]
        [Then(@"I send queuegroups in Styra '(.*)' and launch them '(.*)'")]
        public void GivenISendQueuegroupsinStyraAndLaunchThem(string fileToSend, string fileToLaunch)
        {
            AndroidPage.SendInstructionToQueueGroupBaselineTwo(fileToSend);
            AndroidPage.SendInstructionToQueueGroupBaselineTwo(fileToLaunch);

        }

        [Given(@"I send queuegroups in Styra '([^']*)' and launch them '([^']*)' Nilfisk")]
        public void GivenISendQueuegroupsInStyraAndLaunchThemNilfisk(string fileToSend, string fileToLaunch)
        {
            
            AndroidPage.SendInstructionToQueueGroupNilfisk(fileToSend);
            AndroidPage.LaunchInstructionToQueueGroupNilfisk(fileToLaunch);
        }


        [Given(@"I Confirm & Close pickholders on RFAndroid"), Then(@"I Confirm & Close pickholders on RFAndroid"), When(@"I Confirm & Close pickholders on RFAndroid")]
        public void GivenIConfirmClosePickholdersOnRFAndroid()
        {
            AndroidPage.ConfirmClosePickholders();
        }
        

        [Then(@"I change pickholder unit '(.*)' via navigation menu on RFAndroid")]
        public void ThenIChangePickholderUnitViaNavigationMenuOnRFAndroid(string unit)
        {
            AndroidPage.OpenNavigationMenu();
            AndroidPage.ChangePickholderUnit();
            AndroidPage.SelectUnitForPickholder(unit);
        }

        [Then(@"I Add&Close to pickholder on RFAndroid")]
        public void ThenIAddCloseToPickholderOnRFAndroid()
        {
            AndroidPage.AddCloseAPickholder();
        }

        [When(@"I create a new pickholder on RFAndroid")]
        public void WhenICreateANewPickholderOnRFAndroid()
        {
            AndroidPage.CreateAPickholder();
        }

        [When(@"I click create a new pickholder on RFAndroid")]
        public void WhenIClickCreateANewPickholderOnRFAndroid()
        {
            AndroidPage.ClickCreateAPickholder();
        }

        [When(@"I Add&Close to pickholder on RFAndroid")]
        public void WhenIAddCloseToPickholderOnRFAndroid()
        {
            AndroidPage.AddCloseAPickholder();
        }

        [When(@"I Add to pickholder on RFAndroid"), Then(@"I Add to pickholder on RFAndroid")]
        public void WhenIAddToPickholderOnRFAndroid()
        {
            AndroidPage.AddToPickholder();
        }


        [When(@"I select an unit '(.*)' on RF Android"), Given(@"I select an unit '(.*)' on RF Android"), Then(@"I select an unit '(.*)' on RF Android")]
        public void WhenISelectAnUnitOnRFAndroid(string unit)
        {
            AndroidPage.SelectUnitForPickholder(unit);
        }

        [When(@"I change pickholder unit '(.*)' via navigation menu on RFAndroid")]
        public void WhenIChangePickholderUnitViaNavigationMenuOnRFAndroid(string unit)
        {
            //AndroidPage.SeeScreenSubtitleAppium("Confirmation");
            AndroidPage.OpenNavigationMenu();
            AndroidPage.ChangePickholderUnit();
            AndroidPage.SelectUnitForPickholder(unit);
        }

        [When, Given, Then(@"I clear searched queue group on RFAndroid")]
        public void WhenIClearSearchedQueueGroupOnRFAndroid()
        {
            AndroidPage.ClearSearchValueQueueGroup();
            AndroidPage.GoBackToSearchQueueGroup();
        }

        [Given(@"I clear searched queue group on RFAndroid and go back")]
        [When(@"I clear searched queue group on RFAndroid and go back")]
        [Then(@"I clear searched queue group on RFAndroid and go back")]
        public void WhenIClearSearchedQueueGroupOnRFAndroidAndGoBack()
        {
            AndroidPage.ClearSearchValueQueueGroup();
            AndroidPage.GoBackToSearchQueueGroup();
        }

        //[Given(@"I search and select queuegroup '(.*)' on queuegroup list")]
        [When(@"I search and select queuegroup '(.*)' on queuegroup list")]
        //[Then(@"I search and select queuegroup '(.*)' on queuegroup list")]
        public void WhenISearchAndSelectQueuegroupOnQueuegroupList(string queueGroup)
        {
            AndroidPage.SearchForQueueGroupListPicking(queueGroup);
            AndroidPage.SelectQueueFromSearchQGList(queueGroup);
        }

        //[Given(@"I search and select queuegroup '(.*)' on queuegroup list")]
        [When(@"I search and select queuegroup '(.*)' on queuegroup list after clearing search value")]
        //[Then(@"I search and select queuegroup '(.*)' on queuegroup list")]
        public void WhenISearchAndSelectQueuegroupOnQueuegroupListAfterClearingSearchValue(string queueGroup)
        {
            AndroidPage.SearchForQueueGroupListPickingAfterClearValue(queueGroup);
            AndroidPage.SelectQueueFromSearchQGList(queueGroup);
        }

        [When(@"I click ok to continue work")]
        public void WHenIClickOkToContinueWork()
        {
            AndroidPage.ClickOKButton();
        }

        [Then(@"I should get an error message '(.*)' on RFAppium"), Given(@"I should get an error message '(.*)' on RFAppium")]
        public void ThenIShouldGetAnErrorMessageOnRFAppium(string errorScreenMessage)
        {
            AndroidPage.ErrorMessageOnRFAndroidAppium(errorScreenMessage);
            AndroidPage.ClickOKButtonPopUPMessage();
        }

        [Then(@"I verify the order line '(.*)' exist in outbound details"), Given(@"I verify the order line '(.*)' exist in outbound details")]
        public void ThenIShouldVerifyTheOrderLineExistInOutboundDetails(string orderLineNo)
        {
            AndroidPage.OrderLineAppearInRFRepack(orderLineNo);
            AndroidPage.ClickOKButtonPopUPMessage();
        }

        [When(@"I scan a pickholder '(.*)'"), Given(@"I scan a pickholder '(.*)'")]
        public void WhenIScanAPickholder(string holder)
        {
            AndroidPage.EnterValueOnInputTxtField(holder);
        }

        [Then, Given(@"I go back to search queue group on RFAndroid")]
        public void ThenIGoBackToSearchQueueGroupOnRFAndroid()
        {
            AndroidPage.GoBackToSearchQueueGroup();
        }

        [Then(@"I close pickholder from queue group screen")]
        public void ThenIClosePickholderFromQueueGroupScreen()
        {
            AndroidPage.OpenNavigationMenu();
            AndroidPage.ClickViewPickHolderContent();
            AndroidPage.SeeScreenSubtitleAppium("Pickholder content");
            AndroidPage.ClosePickholder();
        }

        [When(@"I go back (.*) times and logout from RFPortal"), Then(@"I go back (.*) times and logout from RFPortal"), Given(@"I go back (.*) times and logout from RFPortal")]
        public void ThenIGoBackTimesAndLogoutFromRFPortal(int value)
        {
            AndroidPage.PressBackButton(value);
            AndroidPage.LogoutFromRFPortal();
        }

        [Given(@"I login with user '(.*)' on warehouse '(.*)' on RFAndroid")]
        public void GivenILoginWithUserOnWarehouseOnRFAndroid(string badgenumber, string warehouse)
        {
            AndroidPage.LoginBadgeNumber(badgenumber);
            AndroidPage.SelectWarehouse(warehouse);
        }

        [Given(@"I enter the weight of the item '(.*)'")]/*, When(@"I enter the weight of the holder '(.*)*/
        public void GivenIEnterTheWeightOfTheItem(string weight)
        {
            AndroidPage.WeightOfItem(weight);
            //AndroidPage.ClickOKButton();
        }

        [Given(@"I enter holder width '(.*)' of box")]
        public void GivenIEnterHolderWidthOfBox(string holderWidth)
        {
            AndroidPage.EnterHolderWidthOfBox(holderWidth);
        }

        [Given(@"I enter holder depth '(.*)' of box")]
        public void GivenIEnterHolderDepthOfBox(string holderDepth)
        {
            AndroidPage.EnterHolderDepthOfBox(holderDepth);
        }

        [Given(@"I enter holder height '(.*)' of box")]
        public void GivenIEnterHolderHeightOfBox(string holderHeight)
        {
            AndroidPage.EnterHolderHeightOfBox(holderHeight);
            AndroidPage.ClickOKButton();
        }

        [Given(@"I start '(.*)' application performing scroll")]
        public void GivenIStartApplicationPerformingScroll(string app)
        {
            AndroidPage.StartAppPerformingScroll(app);
        }

        [Given(@"I start '(.*)' application by performing scroll")]
        public void GivenIStartApplicationByPerformingScroll(string app)
        {
            AndroidPage.StartAppByPerformingScroll(app);
        }

        [Given(@"I change the holder unit into '(.*)'")]
        public void GivenIChangeTheHolderUnit(string holderUnit)
        {
            AndroidPage.ChangeTheHolderUnit(holderUnit);
        }

        [Given(@"I scan packtable '(.*)'")]
        [Then(@"I scan packtable '(.*)'")]
        [When(@"I scan packtable '(.*)'")]
        public void GivenIScanPacktable(string p0)
        {
            AndroidPage.ScanPacktable(p0);
        }

        [Given(@"I scan packholder '(.*)'")]
        [Then(@"I scan packholder '(.*)'")]
        [When(@"I scan packholder '(.*)'")]
        public void GivenIScanPackholder(string p0)
        {
            AndroidPage.ScanPackholder(p0);
        }

        [When(@"I click on REPACK")]
        [Given(@"I click on REPACK")]
        [Then(@"I click on REPACK")]
        public void GivenIClickOnRepack()
        {
            AndroidPage.ClickOnRepackButton();
        }

        [When(@"I click on outbound button to check the outbound information")]
        [Given(@"I click on outbound button to check the outbound information")]
        [Then(@"I click on outbound button to check the outbound information")]
        public void GivenIClickOnOutboundButton()
        {
            AndroidPage.ClickOnOutboundButton();
        }

        [When(@"I click on CREATE PACKHOLDER")]
        [Given(@"I click on CREATE PACKHOLDER")]
        [Then(@"I click on CREATE PACKHOLDER")]
        public void GivenIClickOnCreatePackholder()
        {
            AndroidPage.ClickOnCreatePackholder();
        }

        [When(@"I click REPORT PROBLEM")]
        [Given(@"I click REPORT PROBLEM")]
        [Then(@"I click REPORT PROBLEM")]
        public void GivenIClickReportProblem()
        {
            AndroidPage.ClickOnReportProblem();
        }

        [When(@"I click close packholder")]
        [Given(@"I click close packholder")]
        [Then(@"I click close packholder")]
        public void GivenIClickClosePackholder()
        {
            AndroidPage.ClickOnClosePackHolder();
        }

        [Given(@"I scan Order Line '(.*)'")]
        [Then(@"I scan Order Line '(.*)'")]
        [When(@"I scan Order Line '(.*)'")]
        public void GivenIScanOrderLine(string p0)
        {
            AndroidPage.ScanOrderLIne(p0);
        }

        [Given(@"I split qty '(.*)'")]
        [Then(@"I split qty '(.*)'")]
        [When(@"I split qty '(.*)'")]
        public void GivenISplitQty(string p0)
        {
            AndroidPage.SplitQty(p0);
        }

        [Given(@"I scan '(.*)' Qty of problem")]
        [Then(@"I scan '(.*)' Qty of problem")]
        [When(@"I scan '(.*)' Qty of problem")]
        public void GivenIScanQtyOfProblem(string p0)
        {
            AndroidPage.ScanQuantityOfProblem(p0);
        }

        [Given(@"I scan '(.*)' for unit")]
        [Then(@"I scan '(.*)' for unit")]
        [When(@"I scan '(.*)' for unit")]
        public void GivenIScanUnitInRepack(string p0)
        {
            AndroidPage.ScanUnitInRepack(p0);
        }

        [Given(@"I scan '(.*)' for weight")]
        [Then(@"I scan '(.*)' for weight")]
        [When(@"I scan '(.*)' for weight")]
        public void GivenIScanWeightInRepack(string p0)
        {
            AndroidPage.ScanWeightInRepack(p0);
        }

        [Given(@"I click on GEZIM TEST as a problem")]
        [Then(@"I click on GEZIM TEST as a problem")]
        [When(@"I click on GEZIM TEST as a problem")]
        public void GivenIScanProblem()
        {
            AndroidPage.ScanProblem();
        }


        [Given(@"I select '(.*)' module while performing scroll")]
        public void GivenISelectWhilePerformingScroll(string module)
        {
            AndroidPage.SelectWhilePerformingScroll(module);
        }



        [Given(@"I click '(.*)' in RFAndroid")]
        public void GivenIClickInRFAndroid(string p0)
        {
            AndroidPage.ClickButton(p0);
        }

       
        [Given(@"I read the request message and validate '([^']*)' value")]
        public void GivenIReadTheRequestMessageAndValidateValue(string p0)
        {
            AndroidPage.ReadTheRequestMessageAndValidateValue(p0);
        }



        [Given(@"I should see text '(.*)' on RFAndroid")]
        public void GivenIShouldSeeTextOnRFAndroid(string p0)
        {
            AndroidPage.ShouldSeeTextOnRFAndroid(p0);
        }


        [Given(@"I Click NEW TYPE '(.*)' in RFAndroid")]
        public void GivenIClickNEWTYPEInRFAndroid(string stock)
        {
            AndroidPage.NewStockHolder(stock);
        }

        [Given(@"I click ok for error message on RFAndroid")]
        [When(@"I click ok for error message on RFAndroid")]
        [Then(@"I click ok for error message on RFAndroid")]
        public void GivenIClickOkForErrorMessageOnRFAndroid()
        {
            AndroidPage.ClickOnErrorMessage();
        }

        [Given(@"I click OK on the error message")]
        public void GivenIClickOKOnTheErrorMessage()
        {
            AndroidPage.ClickOnErrorMessage();
        }


        [Then(@"I clear filter on search queue group")]
        public void ThenIClearFilterOnSearchQueueGroup()
        {
            AndroidPage.ClearSearchValueQueueGroup();
        }


        [Then(@"I go back to previous screen by pressing back button (\d+) times")]
        public void ThenIGoBackToPreviousScreenByPressingBackButtonTimes(int value)
        {
            AndroidPage.PressBackButton(value);
        }

        [Given(@"I scan machine type '(.*)' on RFAndroid")]
        public void GivenIScanMachineTypeOnRFAndroid(string machineType)
        {
            AndroidPage.SeeScreenSubtitleAppium("Machine");
            AndroidPage.ScanMachineType(machineType);
        }

        [Then(@"I go back from Picking Machine screen")]
        public void ThenIGoFromPickingMachineScreen()
        {
            AndroidPage.SeeScreenSubtitleAppium("Machine");
            AndroidPage.PressBackButton();
        }

        [When(@"I scan a TRO '(.*)' on RFAndroid")]
        public void WhenIScanATROOnRFAndroid(string TRO)
        {
            AndroidPage.SeeScreenSubtitleAppium("Transport");
            AndroidPage.EnterValueOnInputTxtField(TRO);
        }

        [When(@"I scan a closed TRO '(.*)' on RFAndroid")]
        public void WhenIScanAClosedTROOnRFAndroid(string closedTRO)
        {
            AndroidPage.SeeScreenSubtitleAppium("Transport");
            AndroidPage.EnterValueOnInputTxtField(closedTRO);
        }

        [When(@"I scan a non-existing TRO '(.*)' on RFAndroid")]
        public void WhenIScanANon_ExistingTROOnRFAndroid(string nonExistingTRO)
        {
            AndroidPage.SeeScreenSubtitleAppium("Transport");
            AndroidPage.EnterValueOnInputTxtField(nonExistingTRO);
        }

        [When(@"I scan license plate '(.*)' for a TRO on RFAndroid")]
        public void WhenIScanLicensePlateForATROOnRFAndroid(string licensePlate)
        {
            AndroidPage.SeeScreenSubtitleAppium("License Plate");
            AndroidPage.EnterValueOnInputTxtField(licensePlate);
        }

        [When(@"I scan a wrong license plate '(.*)' for a TRO on RFAndroid")]
        public void WhenIScanAWrongLicensePlateForATROOnRFAndroid(string wrongLicensePlate)
        {
            AndroidPage.SeeScreenSubtitleAppium("License Plate");
            AndroidPage.EnterValueOnInputTxtField(wrongLicensePlate);
        }

        [When(@"I confirm I am at license plate screen")]
        public void WhenIConfirmIAmAtLicensePlateScreen()
        {
            AndroidPage.SeeScreenSubtitleAppium("License Plate");
        }

        [When(@"I scan a pickholder '(.*)' already loaded")]
        public void WhenIScanAPickholderAlreadyLoaded(string alreadyLoaded)
        {
            AndroidPage.SeeScreenSubtitleAppium("Pickholder");
            AndroidPage.EnterValueOnInputTxtField(alreadyLoaded);
        }

        [When(@"I scan a pickholder '(.*)' not linked to any TRO")]
        public void WhenIScanAPickholderNotLinkedToAnyTRO(string notLinkedtoanyTRO)
        {
            AndroidPage.SeeScreenSubtitleAppium("Pickholder");
            AndroidPage.EnterValueOnInputTxtField(notLinkedtoanyTRO);
        }

        [When(@"I scan a pickholder '(.*)' that is on location ZWEEF")]
        public void WhenIScanAPickholderThatIsOnLocationZWEEF(string onlocationZweef)
        {
            AndroidPage.SeeScreenSubtitleAppium("Pickholder");
            AndroidPage.EnterValueOnInputTxtField(onlocationZweef);
        }

        [When(@"I scan a pickholder '(.*)' linked to another TRO")]
        public void WhenIScanAPickholderLinkedToAnotherTRO(string linkedtoanotherTRO)
        {
            AndroidPage.SeeScreenSubtitleAppium("Pickholder");
            AndroidPage.EnterValueOnInputTxtField(linkedtoanotherTRO);
        }

        [When(@"I scan a pickholder '(.*)' to load on RFAndroid")]
        public void WhenIScanAPickholderToLoadOnRFAndroid(string pickholderToLoad)
        {
            AndroidPage.SeeScreenSubtitleAppium("Pickholder");
            AndroidPage.EnterValueOnInputTxtField(pickholderToLoad); ;
        }

        [Given(@"I press Yes button on RFAndroid")]
        public void ThenIPressYesButtonOnRFAndroid()
        {
            AndroidPage.YesButtonAndroid();
        }

        [Then(@"I press No button on RFAndroid")]
        public void ThenIPressNoButtonOnRFAndroid()
        {
            AndroidPage.NoButtonAndroid();
        }

        [Then(@"I delete holder via webservice '(.*)'")]
        public void ThenIDeleteHolderViaWebservice(string fileToSend)
        {
            AndroidPage.SendInstructionToQueueGroup(fileToSend);
        }

        [When(@"I create a super holder from navigation menu")]
        public void WhenICreateASuperHolderFromNavigationMenu()
        {
            AndroidPage.OpenNavigationMenu();
            AndroidPage.CreateASuperHolder();
        }

        [When(@"I create a super holder from navigation menu bar")]
        public void WhenICreateASuperHolderFromNavigationMenuBar()
        {
            AndroidPage.OpenNavigationMenu();
            AndroidPage.OpenCreateSuperHolder();
            AndroidPage.ClickOKButton();
        }

        [Given(@"I enter width '(.*)' cm")]
        public void GivenIEnterWidthCm(string width)
        {
            AndroidPage.EnterWidthCm(width);
        }

        [Given(@"I enter depth '(.*)' cm")]
        public void GivenIEnterDepthCm(string depth)
        {
            AndroidPage.EnterDepthCm(depth);
        }

        [Given(@"I enter height '(.*)' cm")]
        public void GivenIEnterHeightCm(string height)
        {
            AndroidPage.EnterHeightCm(height);
        }

        [Given(@"I should see Expected-Instock '(.*)' for one item")]
        public void GivenIShouldSeeExpected_InstockForOneItem(string difference)
        {
            AndroidPage.SeeExpected_InstockForOneItem(difference);
        }

        [Given(@"I enter Configuration '(.*)'")]
        public void GivenIEnterConfiguration(string config)
        {
            AndroidPage.EnterConfiguration(config);
        }

        [Given(@"I enter Quantity '(.*)' number")]
        public void GivenIEnterQuantityNumber(string qty)
        {
            AndroidPage.IEnterQuantityNumber(qty);
            AndroidPage.ClickOKButton();
        }

        [Given(@"I click on the navigation menu")]
        [When(@"I click on the navigation menu")]
        [Then(@"I click on the navigation menu")]
        public void GivenIClickNavigationMenu()
        {
            AndroidPage.OpenNavigationMenu();
        }

        [Given(@"I click on change the Pickholder unit")]
        [When(@"I click on change the Pickholder unit")]
        [Then(@"I click on change the Pickholder unit")]
        public void GivenIClickOnChangeThePickholderUnit()
        {
            AndroidPage.ChangeThePickholderUnit();
        }

        [Given(@"I check if element '(.*)' is present")]
        public void GivenICheckIfElementIsPresent(string locator)
        {
            AndroidPage.ICheckIfElementIsPresent(locator);
        }

        [Given(@"I verify that stockholder barcode '(.*)' is there")]
        [When(@"I verify that stockholder barcode '(.*)' is there")]
        [Then(@"I verify that stockholder barcode '(.*)' is there")]
        public void GivenIVerifyThatStockholderBarcodeIsThere(string barcode)
        {
            AndroidPage.IVerifyThatStockholderBarcodeIsThere(barcode);
        }

        [Given(@"I should see alert message with a title '(.*)'")]
        [When(@"I should see alert message with a title '(.*)'")]
        [Then(@"I should see alert message with a title '(.*)'")]
        public void GivenIShouldSeeAlertMessageWithATitle(string alertMessage)
        {
            AndroidPage.IShouldSeeAlertMessageWithATitle(alertMessage);
        }

        [Given(@"I verify that location with the stock '(.*)' is there")]
        [When(@"I verify that location with the stock '(.*)' is there")]
        [Then(@"I verify that location with the stock '(.*)' is there")]
        public void GivenIVerifyThatLocationWithTheStockIsThere(string location)
        {
            AndroidPage.IVerifyThatLocationWithTheStockIsThere(location);
        }

        [Given(@"I check if element '(.*)' is there")]
        public void GivenICheckIfElementAskInspectionIsPresent(string locator)
        {
            AndroidPage.ICheckIfElementAskInspectionIsPresent(locator);
        }

        [Given(@"I check if locator '(.*)' is present")]
        public void GivenICheckIfLocatorIsPresent(string locator)
        {
            AndroidPage.ICheckIfLocatorIsPresent(locator);
        }

        [Given(@"I check if locator '(.*)' is there")]
        public void GivenICheckIfLocatorIsThere(string p0)
        {
            AndroidPage.ICheckIfLocatorIsThere(p0);
        }

        [Given(@"I should see '(.*)' element is present")]
        public void GivenIShouldSeeElementIsPresent(string p0)
        {
            AndroidPage.IShouldSeeElementIsPresent(p0);
        }

        [Given(@"I should see '(.*)' element while performing scroll")]
        public void GivenIShouldSeeElementWhilePerformingScroll(string p0)
        {
            AndroidPage.IShouldSeeElementWhilePerformingScroll(p0);
        }

        [Given(@"I should see '(.*)' locator")]
        public void GivenIShouldSeeLocator(string p0)
        {
            AndroidPage.IShouldSeeLocator(p0);
        }

        [Given(@"I check if '(.*)' is present")]
        public void GivenICheckIfIsPresent(string p0)
        {
            AndroidPage.ICheckIfIsPresent(p0);
        }

        [Given(@"I verify the element '(.*)'")]
        public void GivenIVerifyTheElement(string p0)
        {
            AndroidPage.IVerifyTheElement(p0);
        }

        [Given(@"I verify the element '(.*)' is present")]
        public void GivenIVerifyTheElementIsPresent(string p0)
        {
            AndroidPage.IVerifyTheElementIsPresent(p0);
        }


        [Given(@"I should see screen title '(.*)' appium"), When(@"I should see screen title '(.*)' appium"), Then(@"I should see screen title '(.*)' appium")]
        public void GivenIShouldSeeScreenTitleAppium(string page)
        {
            AndroidPage.IShouldSeeScreenTitleAppium(page);
        }

        [Given(@"I verify that other item '(.*)' is shown"), When(@"I verify that other item '(.*)' is shown"), Then(@"I verify that other item '(.*)' is shown")]
        public void GivenIVerifyThatOtherItemIsShown(string item)
        {
            AndroidPage.IVerifyThatOtherItemIsShown(item);
        }

        [Given(@"I should wait until page is ready and the title of the page is '(.*)'"), When(@"I should wait until page is ready and the title of the page is '(.*)'"), Then(@"I should wait until page is ready and the title of the page is '(.*)'")]
        public void GivenIShouldWaitUntilPageIsReady(string page)
        {
            AndroidPage.IShouldWaitForPageToBeReady(page);
        }


        [Given(@"I click Exit button")]
        public void GivenIClickExitButton()
        {
            AndroidPage.IClickExitButton();
        }

        [Given(@"I select Best Before Date Month'(.*)' Day'(.*)' Year'(.*)' appium")]
        public void GivenISelectBestBeforeDateMonthDayYearAppium(string month, string day, string year)
        {
            AndroidPage.SelectBestBeforeDateMonthDayYearAppium(month, day, year);
        }

        [Given(@"I click eye button")]
        public void GivenIClickEyeButton()
        {
            AndroidPage.IClickEyeButton();
        }

        [Given(@"I validate elements in scanned pickholders page"), When(@"I validate elements in scanned pickholders page")]
        public void GivenIValidateTextInScannedPickholdersPage()
        {
            AndroidPage.IValidateTextInScannedPickholdersPage();
            AndroidPage.ClickOKButton();
        }

        [Given(@"I click View Scanned Pickholders")]
        [When(@"I click View Scanned Pickholders")]
        public void GivenIClickViewScannedPickholders()
        {
            AndroidPage.ClickViewScannedPickholder();
        }

        [Given(@"I validate pickholder '(.*)' on scanned pickholders page")]
        public void GivenIValidatePickholderOnScannedPickholdersPage(string p0)
        {
            AndroidPage.ValidatePickholderOnScannedPickholdersPage(p0);
            AndroidPage.ClickOKButton();
            
        }

        [When(@"I validate '(.*)' SKY on Serial numbers screen subtitle")]
        public void WhenIValidateSKYOnSerialNumbersScreenSubtitle(string sku)
        {
            AndroidPage.ValidateSKYOnSerialNumbersScreenSubtitl(sku);
        }

        [Given(@"i validate '(.*)' units to pick")]
        public void GivenIValidateUnitsToPick(string units)
        {
            AndroidPage.ValidateUnitsToPick(units);
        }

        [Given(@"I validate proposed pickholder '(.*)' in Piece picking")]
        public void GivenIValidateProposedPickholderInPiecePicking(string p0)
        {
            AndroidPage.ValidateProposedPickholderInPiecePicking(p0);
        }


        [Given(@"I enter Quantity/\#PCS '(.*)' number")]
        public void GivenIEnterQuantityPCSNumber(string qty)
        {
            AndroidPage.EnterQuantityPCSNumber(qty);
        }
        [When(@"I enter serial number '(.*)'")]
        public void WhenIEnterSerialNumber(string serialnumber)
        {
            AndroidPage.EnterSerialNumber(serialnumber);
        }

        [When(@"I enter a location '(.*)'")]
        [Given(@"I enter a location '(.*)'")]
        [Then(@"I enter a location '(.*)'")]
        public void WhenIEnterALocation(string location)
        {
            AndroidPage.EnterALocation(location);
        }

        [Given(@"I start '(.*)' application while scrolling page")]
        public void GivenIStartApplicationWhileScrollingPage(string app)
        {
            AndroidPage.StartAppPerformingScroll(app);
        }
        [Given(@"i scan material '(.*)'")]
        [Then(@"i scan material '(.*)'")]
        [When(@"i scan material '(.*)'")]
        public void GivenIScanMaterial(string p0)
        {
            AndroidPage.ScanMaterial(p0);
        }

        [Given(@"I scan a checkdigit '(.*)' of to location")]
        [When(@"I scan a checkdigit '(.*)' of to location")]
        [Then(@"I scan a checkdigit '(.*)' of to location")]
        public void WhenIScanACheckdigitOfToLocation(string value)
        {
            AndroidPage.ScanAnInputOnStyra(value);
        }

        [Given(@"I scan serial number '(.*)'")]
        [When(@"I scan serial number '(.*)'")]
        [Then(@"I scan serial number '(.*)'")]
        public void WhenIScanSerialNumber(string value)
        {
            AndroidPage.ScanSerialNumberStyra(value);
        }

        [Given(@"I scan an item on textfield '(.*)' on STYRA"), When(@"I scan an item on textfield '(.*)' on STYRA"), Then(@"I scan an item on textfield '(.*)' on STYRA")]
        public void GivenIScanAnItemOnTextFieldOnStyra(string input)
        {
            AndroidPage.EnterItemOnInputTxtField(input);
        }
        [Given(@"I pick the exact quantity of the item"), When(@"I pick the exact quantity of the item"), Then(@"I pick the exact quantity of the item")]
        public void GivenIPickTheExactQuantityOfTheItem()
        {
            AndroidPage.PickTheExactQuantityOfItem();
        }
        [Given(@"I scan a newly created Pickholder"), When(@"I scan a newly created Pickholder"), Then(@"I scan a newly created Pickholder")]
        public void GivenIScanANewlyCreatedPickholder()
        {
            AndroidPage.ScanAPIHolder();
        }

        [When(@"I scan location '(.*)'"), Given(@"I scan location '(.*)'"), Then(@"I scan location '(.*)'")]

        public void GivenIScanLocation(string p0)
        {
            AndroidPage.ScanLocation(p0);
        }

        [When(@"I scan the location")]
        [Given(@"I scan the location")]
        [Then(@"I scan the location")]
        public void GivenIScanTheLocation()
        {
            AndroidPage.ScanTheLocation();
        }

        [Given(@"I scan a newly created Superholder"), When(@"I scan a newly created Superholder"), Then(@"I scan a newly created Superholder")]
        public void GivenIScanANewlyCreatedSuperholder()
        {
            AndroidPage.ScanAPIHolder();
        }

        [Given(@"I scan the same new serial number twice"), When(@"I scan the same new serial number twice"), Then(@"I scan the same new serial number twice")]
        public void GivenIScanANewSerialNumberTwice()
        {
            AndroidPage.ScanTheSameNewSerialNumberTwice();
        }

        [Given(@"I scan new serial number"), When(@"I scan new serial number"), Then(@"I scan new serial number")]
        public void GivenIScanNewSerialNumber()
        {
            AndroidPage.ScanNewSerialNumber();
        }

        [When(@"I push button to confirm")]
        [Given(@"I push button to confirm")]
        [Then(@"I push button to confirm")]
        public void WhenIPushButtonToConfirm()
        {
            AndroidPage.PushButtonToConfirm();
        }
        [Then(@"I go back to RFPortal from Styra"), Given(@"I go back to RFPortal from Styra"), When(@"I go back to RFPortal from Styra")]
        public void ThenIGoBackToRFPortalFromStyra()
        {
            AndroidPage.OpenNavigationMenu();
            AndroidPage.ClickExitButtonStyra();
        }
        [Then(@"I should get an error message '(.*)' on Styra")]
        public void ThenIShouldGetAnErrorMessageOnStyra(string errorMessage)
        {
            AndroidPage.ErrorMessageStyra(errorMessage);
            AndroidPage.ClickOkButtonStyra();
        }
        [When(@"I scan a superholder '(.*)'"), Given(@"I scan a superholder '(.*)'")]
        public void WhenIScanASuperHolder(string value)
        {
            AndroidPage.ScanASuperHolder(value);
        }

        [Given(@"I Send the QueueGroups in RF with filename '(.*)'"), When(@"I Send the QueueGroups in RF with filename '(.*)'"), Then(@"I Send the QueueGroups in RF with filename '(.*)'")]
        public void GivenISendTheQueueGroupsinRFWithFilename(string fileName)
        {
            AndroidPage.SendInstructionToQueueGroup(fileName);
        }

        [Given(@"I Send the QueueGroups in RF to create holder with filename '(.*)'"), When(@"I Send the QueueGroups in RF to create holder with filename '(.*)'"), Then(@"I Send the QueueGroups in RF to create holder with filename '(.*)'")]
        public void GivenICreateHolder(string fileName)
        {
            AndroidPage.SendCreateHolder(fileName);
        }

        [When(@"I click hamburger menu from the Piece picking page")]
        [Then(@"I click hamburger menu from the Piece picking page")]
        [Given(@"I click hamburger menu from the Piece picking page")]
        public void WhenIClickHamburgerMenuFromThePiecePickingPage()
        {
            AndroidPage.ClickHamburgerMenuFromThePiecePickingPage();
        }

   

        [Given(@"I verify that stock '(.*)' is shown correctly")]
        [When(@"I verify that stock '(.*)' is shown correctly")]
        [Then(@"I verify that stock '(.*)' is shown correctly")]
        public void GivenIVerifyThatStockIsShownCorrectly(string stock)
        {
            AndroidPage.IVerifyThatStockIsShownCorrectly(stock);
        }

        [Then(@"I should get a warning message '(.*)' on RFAppium"), Given(@"I should get a warning message '(.*)' on RFAppium")]
        public void ThenIShouldGetAWarningMessageOnRFAppium(string warningScreenMessage)
        {
            AndroidPage.WarningMessageOnRFAndroidAppium(warningScreenMessage);
        }

        [When(@"I create a super holder from the transfer to loading page")]
        public void WhenICreateASuperHolderFromTheTransferToLoadingPage()
        {
            AndroidPage.CreateSuperholderMain();
            //AndroidPage.ClickOKButton();
        }

        [Given(@"I scan a newly created Superholder in RF"), When(@"I scan a newly created Superholder in RF"), Then(@"I scan a newly created Superholder in RF")]
        public void GivenIScanANewlyCreatedSuperholderInRF()
        {
            AndroidPage.ScanAPIHolderInRF();
            AndroidPage.ClickOKButton();
        }

        [Given(@"I click '(.*)' from the menu")]
        public void GivenIClickFromTheMenu(string p0)
        {
            AndroidPage.ClickFromTheMenu(p0);
        }

        [Given(@"i select '(.*)' from picking unit")]
        public void GivenISelectFromPickingUnit(string pickingunit)
        {
            AndroidPage.SelectFromPickingUnit(pickingunit);
        }


        [Given(@"I validate text '(.*)' on Otbound Comments")]
        public void GivenIValidateTextOnOtboundComments(string p0)
        {
            AndroidPage.ValidateTextOnOtboundComments(p0);
        }

        [When(@"I scan a pickholder Styra '(.*)'")]
        [Given(@"I scan a pickholder Styra '(.*)'")]
        public void WhenIScanAPickholderStyra(string input)
        {
            AndroidPage.ScanAPickholderStyra(input);
        }

        [When(@"I click on TTL ALL button")]
        public void WhenIClickTTLALLButton()
        {
            AndroidPage.ClickTTLAllButton();
        }

        [When(@"I scroll until i find '(.*)' and click on it")]
        [Then(@"I scroll until i find '(.*)' and click on it")]
        [Given(@"I scroll until i find '(.*)' and click on it")]
        public void WhenIScrollIFindTransferToLoadingClickOnIt(string element)
        {
            AndroidPage.FindTransferToLoadingScrollAndClickOnIt(element);
        }

        [When(@"I scroll until i find the '(.*)' and click on it")]
        [Then(@"I scroll until i find the '(.*)' and click on it")]
        [Given(@"I scroll until i find the '(.*)' and click on it")]
        public void WhenIScrollIFindOtherQueueClickOnIt(string element)
        {
            AndroidPage.FindOtherQueueScrollAndClickOnIt(element);
        }

        [When(@"I scroll until i find the choice '(.*)' and click on it")]
        [Then(@"I scroll until i find the choice '(.*)' and click on it")]
        [Given(@"I scroll until i find the choice '(.*)' and click on it")]
        public void WhenIScrollIFindViewLocationClickOnIt(string element)
        {
            AndroidPage.FindViewLocationScrollAndClickOnIt(element);
        }

        [When(@"I scroll until i find the option '(.*)' and click on it")]
        [Then(@"I scroll until i find the option '(.*)' and click on it")]
        [Given(@"I scroll until i find the option '(.*)' and click on it")]
        public void WhenIScrollIFindVIewStockClickOnIt(string element)
        {
            AndroidPage.FindViewStockScrollAndClickOnIt(element);
        }

        [Given(@"I pick wrong quantity of the item"), When(@"I pick wrong quantity of the item"), Then(@"I pick wrong quantity of the item")]
        public void GivenIPickWrongQuantityOfTheItem()
        {
            AndroidPage.PickWrongQuantityOfItem();
        }
        [When(@"I open problem buttons")]
        [Given(@"I open problem buttons")]
        public void WhenIOpenProblemButtons()
        {
            AndroidPage.ProblemButtonsStyra();
        }
        [When(@"I select problem button '(.*)'")]
        [Given(@"I select problem button '(.*)'")]
        public void WhenISelectProblemButton(string problemButton)
        {
            AndroidPage.SelectProblemButtonStyra(problemButton);
        }
        [When(@"I scan a holderbarcode '(.*)'"), Given(@"I scan a holderbarcode '(.*)'")]
        public void WhenIScanAHolderbarcode(string value)
        {
            AndroidPage.ScanAnInputOnStyra(value);
        }


        [When(@"I scan cart position '(.*)'"), Given(@"I scan cart position '(.*)'"), Then(@"I scan cart position '(.*)'")]

        public void GivenIScanCartPosition(string p0)
        {
            AndroidPage.ScanCart(p0);
        }

        [When(@"I scan drop off location '(.*)'"), Given(@"I scan drop off location '(.*)'"), Then(@"I scan drop off location '(.*)'")]

        public void GivenIScanDropOffLocation(string p0)
        {
            AndroidPage.ScanDropOffLocation(p0);
        }


        [Then(@"I should get message '(.*)'")]
        [Given(@"I should get message '(.*)'")]
        public void ThenIShouldGetMessage(string message)
        {
            AndroidPage.VerifyMessageStyraScreen(message);
            AndroidPage.ClickOkButtonStyra();
        }
        [When(@"I drop material in '(.*)'")]
        [Given(@"I drop material in '(.*)'")]
        [Then(@"I drop material in '(.*)'")]
        public void WhenIDropMaterialIn(string value)
        {
            AndroidPage.ScanAnInputOnStyra(value);
        }
        [When(@"I confirm it by clicking yes")]
        public void WhenIConfirmItByClickingYes()
        {
            AndroidPage.ClickYesAfterProblemButton();
        }


        [Given(@"I select '(.*)' pickzone")]
        public void GivenISelectPickzone(string pickzone)
        {
            AndroidPage.SelectPickzone(pickzone);
        }


        [When(@"i validate last scan info  '(.*)' on TTL RFAndroid")]
        public void WhenIValidateLastScanInfoOnTTLRFAndroid(string p0)
        {
            AndroidPage.ValidateLastScanInfoOnTTLRFAndroid(p0);
        }

        [When(@"I click YES on Warining in picking with serial numbers")]
        public void WhenIClickYESOnWariningInPickingWithSerialNumbers()
        {
            AndroidPage.ClickYESOnWariningInPickingWithSerialNumbers();
        }


        [When(@"I validate weight '(.*)' in Piece Picking on RfAndroid")]
        public void WhenIValidateWeightInPiecePickingOnRfAndroid(string p0)
        {
            AndroidPage.ValidateWeightInPiecePickingOnRfAndroid(p0);
        }






        [AfterScenario("android")]
        public void CloseDriver()
        {
            AndroidPage.Driver.Dispose();
        }
    }
}
