using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTraining.src.code.page;
using SeleniumTraining.src.code.sesion;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class LoginTest : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();


        [TestMethod]
        public void VerifyTheLoginIsSuccessfuly() 
        { 
            //Login
            mainPage.loginbutton.Click();
            loginSection.Login("bootcamp2@mojix.com", "12345");
            
            //Create Project
            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText("TESTautomation12345");
            leftSite.addButton.Click();

            
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("TESTautomation12345"), "ERROR! the project was not created");
            Thread.Sleep(1000);

            //Edit Project
            leftSite.ClickProjectName("TESTautomation12345");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText("testUPDATED12345");
            leftSite.saveButton.Click();


            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("testUPDATED12345"), "ERROR! the project was not updated");
            Thread.Sleep(1000);

            //Delete Project
            leftSite.ClickProjectName("testUPDATED12345");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();

            Thread.Sleep(1000);
            sesion.Session.Instance().GetBrowser().SwitchTo().Alert().Accept();

            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("testUPDATED12345"), "ERROR! the project was not eliminated");



        }
    }
}
