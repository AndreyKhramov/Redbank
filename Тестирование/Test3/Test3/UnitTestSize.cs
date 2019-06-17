using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Test3
{
    [TestClass]
    public class UnitTestSize
    {
        [TestMethod]
        public void TestSize()
        {
            RemoteWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(@"C:/Users/User/Desktop/Радик/6%20семестр%203%20курс/Тестирование/RedBank/index.html");
            NUnit.Framework.Assert.IsTrue(true);
            var lnkSupportUs1 = Driver.FindElementByCssSelector(@"a[href='calc.html']");
            lnkSupportUs1.Click();
            var txtSize = Driver.FindElementById("amount");
            txtSize.Clear();
            txtSize.SendKeys("8");

            var txtInterest = Driver.FindElementById("interest");
            txtInterest.Clear();
            txtInterest.SendKeys("0");

            var txtMaturity = Driver.FindElementById("maturity");
            txtMaturity.Clear();
            txtMaturity.SendKeys("0");

            var Calculate = Driver.FindElementByCssSelector("#calculate");
            var Reset = Driver.FindElementByCssSelector("#reset");
            Reset.Click();
            for (int i = 100; i <= 5000000; i = i + 100000)
            {
                string s1 = i.ToString();
                Calculate.Click();
                txtSize.Clear();
                txtSize.SendKeys(s1);
                NUnit.Framework.Assert.NotNull(Driver.FindElement(By.TagName("td")).Displayed);
            }
            Reset.Click();
            for (int i = 1; i <= 30; i = i + 1)
            {
                string s1 = i.ToString();
                Calculate.Click();
                txtInterest.Clear();
                txtInterest.SendKeys(s1);
                NUnit.Framework.Assert.NotNull(Driver.FindElement(By.TagName("td")).Displayed);
            }
            Reset.Click();
            for (int i = 1; i <= 48; i = i + 1)
            {
                string s1 = i.ToString();
                Calculate.Click();
                txtMaturity.Clear();
                txtMaturity.SendKeys(s1);
                NUnit.Framework.Assert.NotNull(Driver.FindElement(By.TagName("td")).Displayed);
            }
          
       
        }
    }
}
