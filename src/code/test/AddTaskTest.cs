using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_I_Automation_Todoly.src.code.page;
using OpenQA.Selenium.DevTools.V111.DOM;
using SeleniumTraining.src.code.page;
using SeleniumTraining.src.code.sesion;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class AddTaskTest : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();
        MainTasks mainTasks = new MainTasks();

        [TestMethod]
        public void VerifyThatCreateTaskIsSuccessfuly() 
        { 
            //Login
            mainPage.loginbutton.Click();
            loginSection.Login("ruizv.marcelo@gmail.com", "12345");
            
            //Create Project
            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText("TESTautomation12345");
            leftSite.addButton.Click();

            
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("TESTautomation12345"), "ERROR! the project was not created");
            Thread.Sleep(1000);

            //Edit Project
            /*leftSite.ClickProjectName("TESTautomation12345");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText("testUPDATED12345");
            leftSite.saveButton.Click();


            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("testUPDATED12345"), "ERROR! the project was not updated");
            Thread.Sleep(1000);*/

           

            mainTasks.newTaskTextBox.SetText("Test");
            mainTasks.addNewTaskButton.Click();
            Thread.Sleep(3000);

            mainTasks.taskButton.Click();
            Console.WriteLine("click de edited");
            //mainTasks.taskEditTextBox.SetText("edited");
            //Console.WriteLine("Seteado edited");
            mainTasks.taskMenuButton.Click();
            Console.WriteLine("Menu clicked");
            /*mainTasks.taskEditTextBox.Click();
            Console.WriteLine("Edit Clicked");*/
            mainTasks.taskDeleteButton.Click();

            //Delete Project
            leftSite.ClickProjectName("TESTautomation12345");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();

            Thread.Sleep(1000);
            sesion.Session.Instance().GetBrowser().SwitchTo().Alert().Accept();

            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("TESTautomation12345"), "ERROR! the project was not eliminated");

            Thread.Sleep(1000);


        }
    }
}
