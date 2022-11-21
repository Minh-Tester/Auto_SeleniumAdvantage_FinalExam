using Automation_Test_Framework.PageObject;
using Automation_Test_Framework.TestSetup;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation_Test_Framework.Common
{
    public class Common_Flow
    {
        public static void loginFlow(IWebDriver _driver)
        {
            Login_Page loginPage = new Login_Page(_driver);
            loginPage.doLogin(Constant.ADMIN_USER_NAME, Constant.ADMIN_PASSWORD);
        }

        public static void GotoWebTableFlow(IWebDriver _driver)
        {
            Elements_Page elements = new(_driver);
            elements.GotoElementsPage();
            Assert.True(elements.isCorrectRedirect(), "Web redirected correctly ");
            elements.GotoWebTablesPage();

            WebTables_Page webtables = new(_driver);
            webtables.isWebHeaderDisplay();
            Assert.True(webtables.isWebHeaderDisplay(), "WebTable screen is not displayed");
        }


    }
}