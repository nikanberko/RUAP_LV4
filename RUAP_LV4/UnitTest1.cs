using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class CommonActions
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheCommonActionsTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("input-firstname")).Clear();
            driver.FindElement(By.Id("input-firstname")).SendKeys("Pero");
            driver.FindElement(By.Id("input-lastname")).Clear();
            driver.FindElement(By.Id("input-lastname")).SendKeys("peric");
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("pero@pero.com");
            driver.FindElement(By.Id("input-telephone")).Clear();
            driver.FindElement(By.Id("input-telephone")).SendKeys("827189122");
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("peroperic1");
            driver.FindElement(By.Id("input-confirm")).Clear();
            driver.FindElement(By.Id("input-confirm")).SendKeys("peroperic1");
            driver.FindElement(By.XPath("//div[@id='content']/form/fieldset[3]/div/div/label")).Click();
            driver.FindElement(By.Name("agree")).Click();
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("pero@pero.com");
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("peroperic12");
            driver.FindElement(By.Id("input-password")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("input-firstname")).Click();
            driver.FindElement(By.Id("input-firstname")).Clear();
            driver.FindElement(By.Id("input-firstname")).SendKeys("ivan");
            driver.FindElement(By.Id("input-lastname")).Clear();
            driver.FindElement(By.Id("input-lastname")).SendKeys("ivanovic");
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("ivan@ivanovic286.com");
            driver.FindElement(By.Id("input-telephone")).Clear();
            driver.FindElement(By.Id("input-telephone")).SendKeys("09934567892");
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("ivanivanovic1");
            driver.FindElement(By.Id("input-confirm")).Clear();
            driver.FindElement(By.Id("input-confirm")).SendKeys("ivanivanovic1");
            driver.FindElement(By.Name("agree")).Click();
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span[2]")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("ivan@ivanovic286.com");
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("ivanivanovic1");
            driver.FindElement(By.Id("input-password")).SendKeys(Keys.Enter);
            driver.FindElement(By.LinkText("Edit your account information")).Click();
            driver.FindElement(By.Id("input-telephone")).Click();
            driver.FindElement(By.Id("input-telephone")).Clear();
            driver.FindElement(By.Id("input-telephone")).SendKeys("09934567678");
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("ivan@ivanovic286.com");
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("ivanivanovic1");
            driver.FindElement(By.Id("input-password")).SendKeys(Keys.Enter);
            driver.FindElement(By.LinkText("Laptops & Notebooks")).Click();
            driver.FindElement(By.LinkText("Macs (0)")).Click();
            driver.FindElement(By.LinkText("Phones & PDAs (3)")).Click();
            driver.FindElement(By.XPath("//img[@alt='HTC Touch HD']")).Click();
            driver.FindElement(By.Id("button-cart")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[4]/a/span")).Click();
            driver.FindElement(By.LinkText("Estimate Shipping & Taxes")).Click();
            driver.FindElement(By.Id("input-country")).Click();
            new SelectElement(driver.FindElement(By.Id("input-country"))).SelectByText("Croatia");
            driver.FindElement(By.Id("input-zone")).Click();
            new SelectElement(driver.FindElement(By.Id("input-zone"))).SelectByText("Grad Zagreb");
            driver.FindElement(By.Id("input-postcode")).Click();
            driver.FindElement(By.Id("input-postcode")).Clear();
            driver.FindElement(By.Id("input-postcode")).SendKeys("10000");
            driver.FindElement(By.Id("button-quote")).Click();
            driver.FindElement(By.XPath("//div[@id='modal-shipping']/div/div/div[2]/div/label")).Click();
            driver.FindElement(By.Id("button-shipping")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Checkout')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Checkout')]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/form/div/table/tbody/tr/td[4]/div/span/button[2]")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
            driver.FindElement(By.LinkText("MP3 Players")).Click();
            driver.FindElement(By.LinkText("test 18 (0)")).Click();
            driver.FindElement(By.LinkText("Phones & PDAs")).Click();
            driver.FindElement(By.LinkText("Software")).Click();
            driver.FindElement(By.LinkText("Tablets")).Click();
            driver.FindElement(By.LinkText("Components")).Click();
            driver.FindElement(By.LinkText("Mice and Trackballs (0)")).Click();
            driver.FindElement(By.XPath("//a[@id='wishlist-total']/span")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li/span")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Transactions")).Click();
            driver.FindElement(By.XPath("//a[@id='wishlist-total']/span")).Click();
            driver.FindElement(By.LinkText("Address Book")).Click();
            driver.FindElement(By.LinkText("Wish List")).Click();
            driver.FindElement(By.XPath("//aside[@id='column-right']/div/a[6]")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Desktops")).Click();
            driver.FindElement(By.LinkText("Mac (1)")).Click();
            driver.FindElement(By.XPath("//img[@alt='iMac']")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div[2]/div/button/i")).Click();
            driver.FindElement(By.XPath("//a[@id='wishlist-total']/span")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]")).Click();
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
