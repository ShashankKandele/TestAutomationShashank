using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAutomationProj
{
    public class Homepage
    {
        private IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void explicitWait(IWebDriver driver, IWebElement ele, int i)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(i));
            wait.Until(ExpectedConditions.ElementToBeClickable(ele));

        }

        [FindsBy(How = How.XPath, Using = "//a[@class='login']")]
        private IWebElement SignInbtn;
        public IWebElement SignIn { get { return SignInbtn; } }

        [FindsBy(How = How.Id, Using = "email_create")]
        private IWebElement Emailtxt;
        public IWebElement Email { get { return Emailtxt; } }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement CreateAccbtn;
        public IWebElement CreateAcc { get { return CreateAccbtn; } }

        [FindsBy(How = How.Id, Using = "id_gender1")]
        private IWebElement Genderbtn;
        public IWebElement Gender { get { return Genderbtn; } }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        private IWebElement Nametxt;
        public IWebElement Name { get { return Nametxt; } }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        private IWebElement LastNametxt;
        public IWebElement LastName { get { return LastNametxt; } }

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement Pwdtxt;
        public IWebElement Password { get { return Pwdtxt; } }

        [FindsBy(How = How.Id, Using = "days")]
        private IWebElement Daysbtn;
        public IWebElement Days { get { return Daysbtn; } }

        [FindsBy(How = How.Id, Using = "months")]
        private IWebElement Monthsbtn;
        public IWebElement Months { get { return Monthsbtn; } }

        [FindsBy(How = How.Id, Using = "years")]
        private IWebElement Yearsbtn;
        public IWebElement Years { get { return Yearsbtn; } }

        [FindsBy(How = How.Id, Using = "firstname")]
        private IWebElement AddFirstNamettxt;
        public IWebElement FirstName { get { return AddFirstNamettxt; } }

        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement AddLastNametxt;
        public IWebElement AddLastName { get { return AddLastNametxt; } }

        [FindsBy(How = How.Id, Using = "address1")]
        private IWebElement Addresstxt;
        public IWebElement Address { get { return Addresstxt; } }

        [FindsBy(How = How.Id, Using = "city")]
        private IWebElement Citytxt;
        public IWebElement City { get { return Citytxt; } }

        [FindsBy(How = How.Id, Using = "id_state")]
        private IWebElement Statelst;
        public IWebElement State { get { return Statelst; } }

        [FindsBy(How = How.Id, Using = "postcode")]
        private IWebElement Postcodetxt;
        public IWebElement Postcode { get { return Postcodetxt; } }

        [FindsBy(How = How.Id, Using = "id_country")]
        private IWebElement Countrylst;
        public IWebElement Country { get { return Countrylst; } }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        private IWebElement Phonetxt;
        public IWebElement Phone { get { return Phonetxt; } }

        [FindsBy(How = How.Id, Using = "alias")]
        private IWebElement Aliastxt;
        public IWebElement Alias { get { return Aliastxt; } }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        private IWebElement Registerbtn;
        public IWebElement Register { get { return Registerbtn; } }

        [FindsBy(How = How.ClassName, Using = "logout")]
        private IWebElement Logoutbtn;
        public IWebElement Logout { get { return Logoutbtn; } }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Emailsigntxt;
        public IWebElement EmailSignIn { get { return Emailsigntxt; } }

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement Pwdsigntxt;
        public IWebElement PasswordSignIn { get { return Pwdsigntxt; } }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement Loginbtn;
        public IWebElement Login { get { return Loginbtn; } }

        [FindsBy(How = How.XPath, Using = "//a[@title='Women']")]
        private IWebElement Womenlnk;
        public IWebElement Women { get { return Womenlnk; } }

        [FindsBy(How = How.XPath, Using = "//img[@title='Faded Short Sleeve T-shirts']")]
        private IWebElement Prodele;
        public IWebElement Product { get { return Prodele; } }

        [FindsBy(How = How.XPath, Using = "//img[@title='Faded Short Sleeve T-shirts']/../following-sibling::a/span")]
        private IWebElement Quickviewele;
        public IWebElement Quickview { get { return Quickviewele; } }

        [FindsBy(How = How.Id, Using = "quantity_wanted")]
        private IWebElement Qtytxt;
        public IWebElement Quantity { get { return Qtytxt; } }

        [FindsBy(How = How.XPath, Using = "//p[@id='add_to_cart']/button")]
        private IWebElement Addtocartbtn;
        public IWebElement AddToCart { get { return Addtocartbtn; } }

        [FindsBy(How = How.Id, Using = "total_price_container")]
        private IWebElement Totalele;
        public IWebElement Total { get { return Totalele; } }

        [FindsBy(How = How.XPath, Using = "//a[@title='Proceed to checkout']")]
        private IWebElement Proceedchkbtn;
        public IWebElement ProceedChkout { get { return Proceedchkbtn; } }

        [FindsBy(How = How.XPath, Using = "//p/a[@title='Proceed to checkout']")]
        private IWebElement Proceedchkbtn2;
        public IWebElement ProceedToChkout2 { get { return Proceedchkbtn2; } }


        [FindsBy(How = How.XPath, Using = "//button[@name='processAddress']")]
        private IWebElement Proceedchkbtn3;
        public IWebElement ProceedToChkout3 { get { return Proceedchkbtn3; } }

        [FindsBy(How = How.Id, Using = "cgv")]
        private IWebElement Termschk;
        public IWebElement Terms { get { return Termschk; } }

        [FindsBy(How = How.XPath, Using = "//button[@name='processCarrier']")]
        private IWebElement Proceedchkbtn4;
        public IWebElement ProceedToChkout4 { get { return Proceedchkbtn4; } }

        [FindsBy(How = How.XPath, Using = "//a[@class='bankwire']")]
        private IWebElement BankWirelnk;
        public IWebElement BankWire { get { return BankWirelnk; } }

        [FindsBy(How = How.XPath, Using = "//span[text()='I confirm my order']")]
        private IWebElement Confrmbtn;
        public IWebElement ConfirmOrder { get { return Confrmbtn; } }

        [FindsBy(How = How.XPath, Using = "//a[@title='View my customer account']")]
        private IWebElement Custbtn;
        public IWebElement CustomerAccount { get { return Custbtn; } }

        [FindsBy(How = How.XPath, Using = "//a[@title='Orders']")]
        private IWebElement Orderbtn;
        public IWebElement OrderHistory { get { return Orderbtn; } }

        [FindsBy(How = How.XPath, Using = "//span[@class='price']")]
        private IWebElement Priceele;
        public IWebElement Price { get { return Priceele; } }
    }

    }
