using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodilityProject.CommonUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace CodilityProject.PageObjects
{
	class SearchPage
	{
		public bool verifyInputQueryDisplayed()
		{
			WebDriverWait wait = new WebDriverWait(DriverClass.driver, TimeSpan.FromSeconds(15));
			wait.Until(ExpectedConditions.ElementIsVisible(By.Id("search-input")));
			return DriverClass.driver.FindElement(By.Id("search-input")).Displayed;
		}

		public bool verifySearchButtonDisplayed()
		{
			WebDriverWait wait = new WebDriverWait(DriverClass.driver, TimeSpan.FromSeconds(15));
			wait.Until(ExpectedConditions.ElementIsVisible(By.Id("search-button")));
			return DriverClass.driver.FindElement(By.Id("search-button")).Displayed;
		}

		public void clickonSearch()
		{
			DriverClass.driver.FindElement(By.Id("search-button")).Click();
		}

		public bool verifyEmptyQuery(String EmptyText)
		{
			WebDriverWait wait = new WebDriverWait(DriverClass.driver, TimeSpan.FromSeconds(15));
			wait.Until(ExpectedConditions.ElementIsVisible(By.Id("search-results")));
			if (EmptyText.Equals(DriverClass.driver.FindElement(By.Id("search-results")).Text.ToString()))
			{
				return true;
			}
			return false;
		}

		public void enterQueryText(String Query)
		{
			WebDriverWait wait = new WebDriverWait(DriverClass.driver, TimeSpan.FromSeconds(15));
			wait.Until(ExpectedConditions.ElementIsVisible(By.Id("search-input")));
			DriverClass.driver.FindElement(By.Id("search-input")).Click();
			DriverClass.driver.FindElement(By.Id("search-input")).Clear();
			DriverClass.driver.FindElement(By.Id("search-input")).SendKeys(Query);
		}

	}
}
