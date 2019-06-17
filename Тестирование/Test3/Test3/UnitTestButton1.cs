﻿using System;
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
    public class UnitTestButton1
    {
        [TestMethod]
        public void TestButton1()
        {
            RemoteWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(@"C:/Users/User/Desktop/Радик/6%20семестр%203%20курс/Тестирование/RedBank/index.html");
            NUnit.Framework.Assert.IsTrue(true);
            var lnkSupportUs1 = Driver.FindElementByCssSelector(@"a[href='calc.html']");
            lnkSupportUs1.Click();
            var txtSize = Driver.FindElementById("amount");
            txtSize.Clear();
            txtSize.SendKeys("6000");

            var txtInterest = Driver.FindElementById("interest");
            txtInterest.Clear();
            txtInterest.SendKeys("10");

            var txtMaturity = Driver.FindElementById("maturity");
            txtMaturity.Clear();
            txtMaturity.SendKeys("20");

            var Button = Driver.FindElementByCssSelector("#calculate");
            Button.Click();

          NUnit.Framework.Assert.NotNull(Driver.FindElement(By.TagName("td")).Displayed);
            Driver.Close();
           
          
            
        }
    }
}
