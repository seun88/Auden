using Auden.AudenHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Auden.AudenPages
{
    public class LoanFormPage : BaseClass
    {
        private IWebElement min;
        private IWebElement max;
        private IWebElement loanamount;
        private IList<IWebElement> repaymentdaybutton;
        private IWebElement firstRepaymentDate;





        public void andassertmin()
        {
            min = GetElementByClassName("loan-amount__range-slider__input");
            var minimumSliderText = min.GetAttribute("min");
            Assert.True(minimumSliderText.Equals("200"));
        }

        public void andassertmax()
        {
            max = GetElementByClassName("loan-amount__range-slider__input");
            var maximumSliderText = min.GetAttribute("max");
            Assert.True(maximumSliderText.Equals("500"));
        }

        public void andselectamount()
        {
            // selected £350

            IWebElement loanamount = driver.FindElement(By.ClassName("loan-amount__range-slider__input"));
            Actions SliderAction = new Actions(driver);
            SliderAction.ClickAndHold(loanamount).MoveByOffset(0, 200).Release().Perform();
            
        }

        public void selectdate()
        {
            repaymentdaybutton = GetElementsByClassName("date-selector__date");

            foreach (IWebElement day in repaymentdaybutton)
            {
                if (day.GetAttribute("value") == "7")
                {
                    day.Click();
                }

            }
            Thread.Sleep(100);

        }

        public void assertfirstrepaymentdate()
        {
            firstRepaymentDate = GetElementByClassName("loan-schedule__tab__panel__detail__tag__radio");
            var radiotext = firstRepaymentDate.GetAttribute("value");
            Assert.True(radiotext.Contains("2020-06-05"));


            

        }





    }
}
