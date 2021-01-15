using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace DotNETCoreProject
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Console.WriteLine("Setup");
        }
        [Test]
        public void Test1()
        {
            //Driver.Navigate().GoToUrl("https://executeautomation.com");
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//div[@class='o-con'][contains(text(),'Celery')]")).Click();
            //IWebElement element = Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed"));
            //SelectElement select = new SelectElement(element);
            
            // fjsnshshdjshx
            Console.WriteLine("Pass");
            Assert.Pass();
        }
    }
}