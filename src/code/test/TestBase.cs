using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using SeleniumTraining.src.code.sesion;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class TestBase
    {
        [TestInitialize]
        public void OpenBrowser()
        {
            sesion.Session.Instance().GetBrowser().Navigate().GoToUrl("http://todo.ly");
        }

        [TestCleanup]
        public void ClearBrowser()
        {
            sesion.Session.Instance().CloseBrowser();

        }
    }
}
