using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace Module_I_Automation_Todoly.src.code.page
{
    public class MainTasks
    {
        public TextBox newTaskTextBox = new TextBox(By.Id("NewItemContentInput"));
        public Button addNewTaskButton = new Button(By.Id("NewItemAddButton"));
        public Button editTaskButton = new Button(By.XPath("//ul[@id='itemContextMenu']//a[text()='Edit']"));

        public Button taskButton = new Button(By.XPath("//div[@class='ItemContentDiv' and text()='Test']"));
        public Button taskMenuButton = new Button(By.XPath("//img[@style=\"display: inline;\"]"));
        public Button taskEditButton = new Button(By.XPath("//ul[contains(@style,'block')]//a[text()='Edit']"));
        public Button taskDeleteButton = new Button(By.XPath("//ul[contains(@style,'block')]//a[text()='Delete']"));

        public TextBox taskEditTextBox = new TextBox(By.XPath("//div[@class='ItemContentDiv' and text()='Test']"));

        public Button taskChangeRedColor = new Button(By.XPath("//div[@class='PrioFrameOuter']/span[@iconid=1]"));

        public Boolean TaskNameDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("//div[@class='ItemContentDiv' and text()='" + nameValue + "']"));
            return nameProject.IsControlDisplayed();
        }

        public Boolean TaskColorIsChanged() 
        {
            Label taskColor = new Label(By.XPath("//div[@style='color: rgb(255, 51, 0); font-weight: bold;']"));
            return taskColor.IsControlDisplayed();
        }
    }
}
