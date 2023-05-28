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
        public Button taskEditButton = new Button(By.XPath("//ul[contains(@style,'block')]//a[@href='#edit']"));
        public Button taskDeleteButton = new Button(By.XPath("//ul[contains(@style,'block')]//a[text()='Delete']"));

        public TextBox taskEditTextBox = new TextBox(By.XPath("//div[@class='ItemContentDiv' and text()='TestTaskMarcelo']"));



        public void ClickTaskName(String nameValue)
        {
            Label nameTask = new Label(By.XPath("//div[@class='ItemContentDiv' and text()='"+nameValue+"']"));
            nameTask.Click();
        }

        public void OptionMenu (String nameValue) 
        {
            Label dropDownMenu = new Label(By.XPath("//ul[@id='mainItemList']/li [last()]/div/table/tbody/tr/td[@class='ItemIndicator']/div/img"));
            dropDownMenu.Click();

            Label clickOption = new Label(By.XPath("//ul[@id='itemContextMenu']/li/a[text()='" + nameValue + "']"));
            clickOption.Click();
        }
    }
}
