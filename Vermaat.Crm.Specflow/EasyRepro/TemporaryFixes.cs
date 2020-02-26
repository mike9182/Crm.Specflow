using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vermaat.Crm.Specflow.EasyRepro
{
    public static class TemporaryFixes
    {
        /// <summary>
        /// Set Value
        /// </summary>
        /// <param name="field">The field</param>
        /// <param name="value">The value</param>
        /// <example>xrmApp.Entity.SetValue("firstname", "Test");</example>
        public static BrowserCommandResult<bool> SetValueFix(this WebClient client, string field, string value)
        {
            return client.Execute(BrowserOptionHelper.GetOptions($"Set Value"), driver =>
            {
                var query = By.XPath(AppElements.Xpath[AppReference.Entity.TextFieldContainer].Replace("[NAME]", field));
                IWebElement fieldContainer = WaitUntilClickable(driver, query, TimeSpan.FromSeconds(5), null, null);

                if (fieldContainer == null)
                {
                    throw new TestExecutionException(Constants.ErrorCodes.ELEMENT_NOT_INTERACTABLE, $"Field {field} is probably locked or invisible");
                }

                IWebElement input;
                if (fieldContainer.FindElements(By.TagName("input")).Count > 0)
                {
                    input = fieldContainer.FindElement(By.TagName("input"));

                }
                else if (fieldContainer.FindElements(By.TagName("textarea")).Count > 0)
                {
                    input = fieldContainer.FindElement(By.TagName("textarea"));
                }
                else
                {
                    throw new Exception($"Field with name {field} does not exist.");
                }

                if (input != null)
                {
                    input.SendKeys(Keys.Control + "a");
                    input.SendKeys(Keys.Backspace);

                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        input.SendKeys(value);
                    }

                    input.SendKeys(Keys.Tab + Keys.Tab);
                }

                return true;
            });
        }

       
        private static IWebElement WaitUntilClickable(IWebDriver driver, By by, TimeSpan timeout, Action<IWebDriver> successCallback, Action<IWebDriver> failureCallback)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            bool? success;
            IWebElement returnElement = null;

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));

            try
            {
                returnElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
                success = true;
            }
            catch (NoSuchElementException)
            {
                success = false;
            }
            catch (WebDriverTimeoutException)
            {
                success = false;
            }

            if (success.HasValue && success.Value && successCallback != null)
                successCallback(driver);
            else if (success.HasValue && !success.Value && failureCallback != null)
                failureCallback(driver);

            return returnElement;
        }
    }
}
