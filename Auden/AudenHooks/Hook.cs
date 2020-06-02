using Auden.AudenHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Auden.AudenHooks
{
    [Binding]
    public sealed class Hook
    {
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            BaseClass.LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            BaseClass.CloseBrowser();
        }
    }
}
