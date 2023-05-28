using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTraining.src.code.page;


namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class ProjectTest : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        MenuSection menuSection = new MenuSection();


        [TestMethod]
        public void VerifyCRUDProject() 
        {
            mainPage.loginbutton.Click();
            loginSection.emailTxtBox.SetText("bootcamp2@mojix.com");
            loginSection.pwdTxtBox.SetText("12345");
            loginSection.loginButton.Click();

            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(),
                "ERROR !! the login was not successfuly, review credentials please");
        }
    }
}
