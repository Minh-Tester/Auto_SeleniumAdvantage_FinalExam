using OpenQA.Selenium;
using Automation_Test_Framework.DriverCore;
using NUnit.Framework;
using Microsoft.AspNetCore.Http;
using Automation_Test_Framework.TestSetup;

namespace Test.PageObject
{
    public class Home_Page : WebDriverAction

    {
        public Home_Page(IWebDriver driver) : base(driver)
        {
        }

        private static String sctElements = "//h5[contains(text(),'Elements')]";
        private static String addedURL = "/elements";


        public void clickElements()
        {
            Click(sctElements);
        }


        public bool isCorrectRedirect()
        {
            if(Constant.BASE_URL + addedURL == getUrl())
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
