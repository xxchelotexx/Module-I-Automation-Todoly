using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page
{
    public class MainPage
    {
        public Button loginbutton = new Button(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]"));
    }
}
