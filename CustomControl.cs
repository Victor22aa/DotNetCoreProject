using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCoreProject 
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(string value)
        {
            IWebElement comboControl = Driver.FindElement(By.Id("ContentPlaceHolder1_AllMealsCombo-awed"));

            comboControl.Clear();
            comboControl.SendKeys(value);

            Driver.FindElement(By.XPath("//li[@class='o-itm o-v o-ditm focus']")).Click();
        }
      
    }
}
