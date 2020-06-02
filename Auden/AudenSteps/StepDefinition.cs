using Auden.AudenHelper;
using Auden.AudenPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Auden.AudenSteps
{
    [Binding]
    public sealed class StepDefinition
    {
        private LoanFormPage lp;



        [Given(@"I navigate to Auden site")]
        public void GivenINavigateToAudenSite()
        {
            lp = BaseClass.GivenINavigateToAudenWebsite();
        }

        [Given(@"i assert Minimum loan amount")]
        public void GivenIAssertMinimumLoanAmount()
        {
            lp.andassertmin();
        }

        [Given(@"assert maximum loan amount")]
        public void GivenAssertMaximumLoanAmount()
        {
            lp.andassertmax();
        }

        [When(@"i select loan amount")]
        public void WhenISelectLoanAmount()
        {
            lp.andselectamount();
        }

        [When(@"select weekend as repayment date")]
        public void WhenSelectWeekendAsRepaymentDate()
        {
            lp.selectdate();
        }

        [Then(@"assert weekday for repayment")]
        public void ThenAssertWeekdayForRepayment()
        {
            lp.assertfirstrepaymentdate();
        }

    }
}
