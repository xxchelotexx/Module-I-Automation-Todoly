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
    public class TaskTests : TestBase
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
            leftSite.projectNameTxtBox.SetText("TESTproject");
            leftSite.addButton.Click();

            
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("TESTproject"), "ERROR! the project was not created");
            Thread.Sleep(1000);

                
            //Create Task
            mainTasks.newTaskTextBox.SetText("Test");
            mainTasks.addNewTaskButton.Click();
           

            Assert.IsTrue(mainTasks.TaskNameDisplayed("Test"), "Error! the task was not created");

            //Change TaskColor
            mainTasks.taskButton.Click();
            mainTasks.taskMenuButton.Click();
            mainTasks.taskMenuButton.Click();
            mainTasks.taskChangeRedColor.Click();
            Assert.IsTrue(mainTasks.TaskColorIsChanged(), "Error! the task color was not changed");
            

            //Delete Task
            mainTasks.taskButton.Click();
            mainTasks.taskMenuButton.Click();
            mainTasks.taskDeleteButton.Click();
            Thread.Sleep(1000);
            Assert.IsFalse(mainTasks.TaskNameDisplayed("Test"), "ERROR! the task was not deleted");            
           
            //Delete Project
            leftSite.ClickProjectName("TESTproject");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();

            sesion.Session.Instance().GetBrowser().SwitchTo().Alert().Accept();


        }
    }
}
