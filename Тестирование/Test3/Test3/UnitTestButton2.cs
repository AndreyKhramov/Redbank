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
    public class UnitTestButton2
    {
        [TestMethod]
        public void TestButton2()
        {
            RemoteWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(@"C:/Users/User/Desktop/Радик/6%20семестр%203%20курс/Тестирование/RedBank/index.html");
            NUnit.Framework.Assert.IsTrue(true);
            var lnkSupportUs1 = Driver.FindElementByCssSelector(@"a[href='calc.html']");
            lnkSupportUs1.Click();
            var txtSize = Driver.FindElementById("amount");
            txtSize.Clear();
            txtSize.SendKeys("1000000");

            var txtInterest = Driver.FindElementById("interest");
            txtInterest.Clear();
            txtInterest.SendKeys("30");

            var txtMaturity = Driver.FindElementById("maturity");
            txtMaturity.Clear();
            txtMaturity.SendKeys("40");

           var Button = Driver.FindElementByCssSelector("#reset");
           Button.Click();
          


           var size = txtSize.GetAttribute("value");
           var interest = txtInterest.GetAttribute("value");
           var maturity = txtMaturity.GetAttribute("value");

           NUnit.Framework.Assert.False(size == "1000000");
           NUnit.Framework.Assert.False(interest == "30");
           NUnit.Framework.Assert.False(maturity == "40");
              
            
            
            Driver.Close();
              
           
        }
    }
}
