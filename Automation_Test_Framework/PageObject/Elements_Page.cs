using OpenQA.Selenium;
using Automation_Test_Framework.DriverCore;
using NUnit.Framework;
using Microsoft.AspNetCore.Http;
using Automation_Test_Framework.TestSetup;
using Automation_Test_Framework.TestSetData;
using Automation_Test_Framework.DAO;

namespace Automation_Test_Framework.PageObject
{
    public class Elements_Page : WebDriverAction
    {
        public Elements_Page(IWebDriver driver) : base(driver)
        {
        }

        private static String sctElements = "//h5[contains(text(),'Elements')]";
        private static String btnTables = "//span[contains(text(),'Web Tables')]";
        private static String addedURL = "/elements";


        public void GotoElementsPage()
        {
            Click(sctElements);
        }
        public void GotoWebTablesPage()
        {
            Click(btnTables);
        }
        public bool isCorrectRedirect()
        {
            if (Constant.BASE_URL + addedURL == getUrl())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
