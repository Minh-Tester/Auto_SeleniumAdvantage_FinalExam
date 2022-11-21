using Automation_Test_Framework.TestSetup;
using NUnit.Framework;
using Test.PageObject;
using NUnit.Framework.Internal;
using Automation_Test_Framework.DriverCore;
using Automation_Test_Framework.PageObject;
using Automation_Test_Framework.DAO;
using OpenQA.Selenium;
using Automation_Test_Framework.Common;

namespace Automation_Test_Framework.TestCase
{
    [TestFixture]
    public class WebTables_Test : ProjectNUnit
    {
        public void VerifyCreatedEmployees(EmployeesDAO employees)
        {
            //Employees
        }

        [Test]
        public void ID02_createNewEmployee()
        {
            Elements_Page elements = new(_driver);
            elements.GotoElementsPage();
            Assert.True(elements.isCorrectRedirect(), "Web redirected correctly ");
            elements.GotoWebTablesPage();

            WebTables_Page webtables = new(_driver);
            webtables.isWebHeaderDisplay();
            Assert.True(webtables.isWebHeaderDisplay(), "WebTable screen is not displayed");

            WebTables_Page create_Employee = new WebTables_Page(_driver);
            create_Employee.clickButtonAdd();

            EmployeesDAO employees = new("Tony", "Tran", "tonytran21092000@gmail.com", "22", "15000000", "Hanoi");
            create_Employee.inputEmployeesInfo(employees);
            create_Employee.clickSubmit();
        }


        [Test]
        public void ID01_displayDefaultInformation()
        {
            Elements_Page elements = new(_driver);
            elements.GotoElementsPage();
            Assert.True(elements.isCorrectRedirect(), "Web redirected correctly ");
            elements.GotoWebTablesPage();

            WebTables_Page webtables = new(_driver);
            webtables.isWebHeaderDisplay();
            Assert.True(webtables.isWebHeaderDisplay(), "WebTable screen is not displayed");


        }


        [Test]
        public void ID03_upadateAndDeleteEmployee()
        {

            Elements_Page elements = new(_driver);
            elements.GotoElementsPage();
            Assert.True(elements.isCorrectRedirect(), "Web redirected correctly ");
            elements.GotoWebTablesPage();

            WebTables_Page webtables = new(_driver);
            webtables.isWebHeaderDisplay();
            Assert.True(webtables.isWebHeaderDisplay(), "WebTable screen is not displayed");


            WebTables_Page update_and_delete_ = new WebTables_Page(_driver);
            update_and_delete_.clickButtonEdit();
            update_and_delete_.clearEmployeeInfo();

            EmployeesDAO update_employees = new("Tony", "Tran", "tonytran21092000@gmail.com", "22", "15000000", "Hanoi");
            update_and_delete_.inputEmployeesInfo(update_employees);
            update_and_delete_.clickSubmit();

           update_and_delete_.clickButtonDelete();




        }

    }
}
