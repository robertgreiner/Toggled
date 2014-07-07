using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Toggled.Tests
{
    [Binding]
    public class TogglesSteps
    {
        private double num = 0;
        private double result = 0;

        [Given(@"I have a numerical value")]
        public void GivenIHaveANumericalValue()
        {
            num = 100.5;
        }

        [When(@"I process the value")]
        public void WhenIProcessTheValue()
        {
            result = NumberService.ProcessNumber(num);
        }

        [Then(@"the result should round up to the nearest integer")]
        public void ThenTheResultShouldRoundUpToTheNearestInteger()
        {
            Assert.AreEqual(101, result);
        }
    }
}
