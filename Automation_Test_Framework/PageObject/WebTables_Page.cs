using OpenQA.Selenium;
using Automation_Test_Framework.DriverCore;
using Automation_Test_Framework.DAO;
using NUnit.Framework;
using Microsoft.AspNetCore.Http;
using Automation_Test_Framework.TestSetup;
using Automation_Test_Framework.TestSetData;

namespace Automation_Test_Framework.PageObject
{
    public class WebTables_Page : WebDriverAction
    {
        public WebTables_Page(IWebDriver driver) : base(driver)
        {
        }

        private static String headerWebTables = "//div[contains(text(),'Web Tables')]";
        private static String tfFirstName = "//input[@id='firstName']";
        private static String tfLastName = "//input[@id='lastName']";
        private static String tfEmail = "//input[@id='userEmail']";
        private static String tfAge = "//input[@id='age']";
        private static String tfSalary = "//input[@id='salary']";
        private static String tfDepartment = "//input[@id='department']";
        private static String btnSubmit = "//button[@id='submit']";
        private static String btnAdd = "//button[contains(text(),'Add')]";
        private static String btnEdit = "(//span[@title = 'Edit'])[3]";
        private static String btnDelete = "(//span[@title = 'Delete'])[3]";


        public bool isWebHeaderDisplay()
        {
            if (isElementDisplay(headerWebTables) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void inputEmployeesInfo(EmployeesDAO employees)
        {
            SendKeys_(tfFirstName, employees.FirstName);
            SendKeys_(tfLastName, employees.LastName);
            SendKeys_(tfEmail, employees.Email);
            SendKeys_(tfAge, employees.Age);
            SendKeys_(tfSalary, employees.Salary);
            SendKeys_(tfDepartment, employees.Department);

        }

        public void clickSubmit()
        {
            Click(btnSubmit);
        }

        public void clickButtonAdd()
        {
            Click(btnAdd);
        }

        public void clickButtonEdit()
        {
            Click(btnEdit);
        }

        public void clickButtonDelete()
        {
            Click(btnDelete);
        }

        public void clearEmployeeInfo()
        {
            Clear(tfFirstName);
            Clear(tfLastName);
            Clear(tfEmail);
            Clear(tfAge);
            Clear(tfSalary);
            Clear(tfDepartment);
        }

        
    }
}
