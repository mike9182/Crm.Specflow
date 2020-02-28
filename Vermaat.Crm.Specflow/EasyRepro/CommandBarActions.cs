﻿using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.Xrm.Sdk;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vermaat.Crm.Specflow.FormLoadConditions;

namespace Vermaat.Crm.Specflow.EasyRepro
{
    public class CommandBarActions
    {
        private readonly UCIApp _app;

        public CommandBarActions(UCIApp app)
        {
            _app = app;
        }

        public void ClickButton(string buttonText)
        {
            _app.App.CommandBar.ClickCommand(buttonText);
        }


        public void ActivateQuote()
        {
            Logger.WriteLine("Activating Quote");
            ClickButton(_app.ButtonTexts[Constants.ButtonTexts.ActivateQuote]);
        }

        public EntityReference CreateOrder()
        {
            Logger.WriteLine("Creating Sales Order from Quote");
            ClickButton(_app.ButtonTexts[Constants.ButtonTexts.CreateOrder]);
            CreateOrderDialog();

            return new EntityReference("salesorder", _app.App.Entity.GetObjectId());
        }

        public bool IsButtonAvailable(string ribbonButton)
        {
            return _app.Client.IsRibbonButtonAvailable(ribbonButton);
        }

        public void Delete()
        {
            Logger.WriteLine($"Deleting record");
            ClickButton(_app.ButtonTexts[Constants.ButtonTexts.Delete]);
            _app.App.Dialogs.ConfirmationDialog(true);
        }

        public EntityReference ReviseQuote()
        {
            Logger.WriteLine("Revising Quote");
            ClickButton(_app.ButtonTexts[Constants.ButtonTexts.ReviseQuote]);

            _app.Client.Browser.ThinkTime(1000);
            HelperMethods.WaitForFormLoad(_app.WebDriver);

            return new EntityReference("quote", _app.App.Entity.GetObjectId()); ;           
        }

        private void CreateOrderDialog()
        {
            //Todo: Find a better place for this
            _app.Client.Execute(BrowserOptionHelper.GetOptions($"Create Sales Order"), driver =>
            {
                var container = driver.WaitUntilAvailable(SeleniumFunctions.Selectors.GetXPathSeleniumSelector(SeleniumSelectorItems.Dialog_Container));
                var button = container.FindElement(SeleniumFunctions.Selectors.GetXPathSeleniumSelector(SeleniumSelectorItems.Dialog_OK));

                button.Click();
                HelperMethods.WaitForFormLoad(driver, new FormIsOfEntity("salesorder"));

                return true;
            });
        }
    }
}
