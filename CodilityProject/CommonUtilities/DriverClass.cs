using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using NUnit.Framework;
using System.Reflection;

namespace CodilityProject.CommonUtilities
{
    public static class DriverClass
    {
        public static IWebDriver driver = null;

        public static void initiateDriver(string BaseURL)
        {
            ChromeOptions ChromeOptions = new ChromeOptions();
            ChromeOptions.AddAdditionalCapability("useAutomationExtension", false);
            ChromeOptions.AddArguments("--start-maximized");
            ChromeOptions.AddArguments("--no-sandbox");
            //ChromeOptions.AddArgument("--headless");
            string strBaseDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            string strDriverPath = Path.Combine(strBaseDir, "Drivers");
            driver = new ChromeDriver(strDriverPath, ChromeOptions);
            driver.Navigate().GoToUrl(BaseURL);

        }
        public static void quitDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
