using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using CodilityProject.CommonUtilities;
using NUnit.Framework;
using CodilityProject.PageObjects;


namespace CodilityProject.StepDefinition
{
    [Binding]
    public sealed class CodilityStepDefinition
    {
        SearchPage sp = new SearchPage();
        [Given(@"I navigated to the website '(.*)'")]
        public void GivenINavigatedToTheWebsite(string URL)
        {
            DriverClass.initiateDriver(URL);
        }


        [Then(@"I can see query input field is displayed")]
        public void ThenICanSeeQueryInputFieldIsDisplayed()
        {
            Assert.IsTrue(sp.verifyInputQueryDisplayed());
        }

        [Then(@"I can also see search button is displayed")]
        public void ThenICanAlsoSeeSearchButtonIsDisplayed()
        {
            Assert.IsTrue(sp.verifySearchButtonDisplayed());
        }

        [Then(@"I verify to use an empty query ""(.*)"" error message is displaying")]
        public void ThenIVerifyToUseAnEmptyQueryErrorMessageIsDisplaying(string emptyquery)
        {
            sp.clickonSearch();
            Assert.IsTrue(sp.verifyEmptyQuery(emptyquery));

        }

        [When(@"I querying for ""(.*)""")]
        public void WhenIQueryingFor(string query)
        {
            sp.enterQueryText(query);
        }

        [Then(@"I verify ""(.*)"" message is displaying")]
        public void ThenIVerifyMessageIsDisplaying(string query)
        {
            sp.clickonSearch();
            Assert.IsTrue(sp.verifyEmptyQuery(query));
        }

    }
}
