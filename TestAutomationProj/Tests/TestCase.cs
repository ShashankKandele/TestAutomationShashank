using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestAutomationProj
{
    [TestClass]
    public class TestCase : Abstract
    {
        Homepage home = new Homepage(driver);
        string url = "http://automationpractice.com/index.php";

        [TestInitialize]
        public void TestSetup()
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        [TestMethod]
        [DeploymentItem(@".\Resources")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "TestDataAutomation.csv", "TestDataAutomation#csv", DataAccessMethod.Sequential)]

        [Priority(1)]
        public void Signup()
        {
            var Email = TestContext.DataRow["Email"].ToString();
            var FirstName = TestContext.DataRow["FirstName"].ToString();
            var LastName = TestContext.DataRow["LastName"].ToString();
            var Password = TestContext.DataRow["Password"].ToString();
            var Days = TestContext.DataRow["Days"].ToString();
            var Months = TestContext.DataRow["Months"].ToString();
            var Years = TestContext.DataRow["Years"].ToString();
            var Address = TestContext.DataRow["Address"].ToString();
            var City = TestContext.DataRow["City"].ToString();
            var State = TestContext.DataRow["State"].ToString();
            var Country = TestContext.DataRow["Country"].ToString();
            var PostCode = TestContext.DataRow["PostCode"].ToString();
            var Phone = TestContext.DataRow["Phone"].ToString();
            var Alias = TestContext.DataRow["Alias"].ToString();

            home.SignIn.Click();
            home.explicitWait(driver, home.Email, 10);
            home.Email.SendKeys(Email);
            home.CreateAcc.Click();
            home.explicitWait(driver, home.Gender, 10);
            home.Gender.Click();
            home.Name.SendKeys(FirstName);
            home.LastName.SendKeys(LastName);
            home.Password.SendKeys(Password);

            SelectElement daysselect = new SelectElement(home.Days);
            daysselect.SelectByValue(Days);

            SelectElement Monthsselect = new SelectElement(home.Months);
            Monthsselect.SelectByValue(Months);

            SelectElement Yearsselect = new SelectElement(home.Years);
            Yearsselect.SelectByValue(Years);

            home.Address.SendKeys(Address);
            home.City.SendKeys(City);

            SelectElement Stateselect = new SelectElement(home.State);
            Stateselect.SelectByText(State);

            SelectElement Countryselect = new SelectElement(home.Country);
            Countryselect.SelectByText(Country);

            home.Postcode.SendKeys(PostCode);
            home.Phone.SendKeys(Phone);
            home.Alias.Clear();
            home.Alias.SendKeys(Alias);
            home.Register.Click();
            home.explicitWait(driver, home.Logout, 10);
            string Name = string.Concat(FirstName, LastName);
            Assert.AreEqual(Name, home.CustomerAccount.Text);

        }
        [TestMethod]
        [DeploymentItem(@".\Resources")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "TestDataAutomation.csv", "TestDataAutomation#csv", DataAccessMethod.Sequential)]

        [Priority(0)]
        public void Shop()
        {
            home.explicitWait(driver, home.SignIn, 10);
            home.SignIn.Click();
            var Email = TestContext.DataRow["Email"].ToString();
            var Password = TestContext.DataRow["Password"].ToString();

            home.explicitWait(driver, home.EmailSignIn, 10);
            home.EmailSignIn.SendKeys(Email);
            home.PasswordSignIn.SendKeys(Password);
            home.Login.Click();

            home.Women.Click();

            home.explicitWait(driver, home.Product, 10);
            Actions action = new Actions(driver);
            action.MoveToElement(home.Product).Perform();
            action.MoveToElement(home.Quickview).Perform();

            home.Quickview.Click();


            driver.SwitchTo().Frame(0);
            home.explicitWait(driver, home.AddToCart, 10);
            var Quantity = TestContext.DataRow["Quantity"].ToString();
            home.Quantity.Clear();
            home.Quantity.SendKeys(Quantity);

            home.AddToCart.Click();

            home.explicitWait(driver, home.ProceedChkout, 10);
            home.ProceedChkout.Click();

            var Total = home.Total.Text;
            home.explicitWait(driver, home.ProceedToChkout2, 10);
            home.ProceedToChkout2.Click();

            home.explicitWait(driver, home.ProceedToChkout3, 10);
            home.ProceedToChkout3.Click();

            home.explicitWait(driver, home.ProceedToChkout4, 10);
            home.Terms.Click();
            home.ProceedToChkout4.Click();

            home.explicitWait(driver, home.BankWire, 10);
            home.BankWire.Click();

            home.explicitWait(driver, home.ConfirmOrder, 10);
            home.ConfirmOrder.Click();

            home.explicitWait(driver, home.CustomerAccount, 10);
            home.CustomerAccount.Click();

            home.explicitWait(driver, home.OrderHistory, 10);
            home.OrderHistory.Click();

            home.explicitWait(driver, home.CustomerAccount, 10);
            Assert.AreEqual(Total, home.Price.Text);

        }
        [ClassCleanup]
        public static void classcleanup()
        {
            if (!(driver == null))
            {
                driver.Quit();
            }
        }
    }
}


