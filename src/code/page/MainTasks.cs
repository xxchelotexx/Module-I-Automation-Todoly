using System;
using System.Collections.Generic;
using System.Linq;
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
