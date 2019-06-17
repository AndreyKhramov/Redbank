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
    public class UnitTestNavigation
    {
        [TestMethod]
        public void TestNavigation()
        {
            RemoteWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(@"C:/Users/User/Desktop/Радик/6%20семестр%203%20курс/Тестирование/RedBank/index.html");
            var lnkSupportUs1 = Driver.FindElementByCssSelector(@"a[href='calc.html']");
            lnkSupportUs1.Click();
            var lnkSupportUs2 = Driver.FindElementByCssSelector(@"a[href='index.html']");
            lnkSupportUs2.Click();
            var Button = Driver.FindElementByCssSelector("body > div > div.content > div.main > div.Absolute-Center > a > button");
            Button.Click();
            NUnit.Framework.Assert.IsTrue(Driver.Title=="Калькулятор ипотеки");
           Driver.Close();
           
        }
    }
}
