using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTraining.src.code.factoryBrowser;

namespace SeleniumTraining.src.code.sesion
{
    internal class Session
    {
        // atributo del mismo tipo
        private static Session instance = null;
        private IWebDriver browser;

        // constructor privado
        private Session() 
        { 
            browser = FactoryBrowser.Make("chrome").Create();
        }
        
        // metodo estatico publico para su acceso global
        public static Session Instance()
        {
            if (instance == null) 
            {   
            instance = new Session();
            }
            return instance;
        }
        
        public void CloseBrowser() 
        {
            instance = null;
            browser.Quit();
        }
        
        public IWebDriver GetBrowser() 
        { 
            return browser;
        }
    }
}
