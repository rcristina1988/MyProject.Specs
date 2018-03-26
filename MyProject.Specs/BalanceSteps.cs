using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TechTalk.SpecFlow;

namespace MyProject.Specs
{
    [Binding]
    public class BalanceSteps
    {
        [BeforeScenario]
        public void Setup()
        {
            Driver.Intitialize();
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
        }

        [AfterScenario]
        public void TearDown ()
        {
            Driver.Close();
        }

        [Given("I am in a full loaded application")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
           
        }

        [When("I logged into the app")]
        public void WhenIPressAdd()
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("the balance should be displayed")]
        public void ThenTheResultShouldBe(int result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
    }
}
