using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProj
{
	public abstract class Abstract
	{
        protected static TestContext testContext;
        public TestContext TestContext
        {
            get
            {
                return testContext;
            }
            set
            {
                testContext = value;
            }
        }

        public static IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);
    }
}

