using Core_Framework.NUnit_Test_Setup;
using NUnit.Framework;

namespace Automation_Test_Framework.TestSetup
{
    public class ProjectNUnit : NUnit_Test_Setup
    {
        [SetUp]
        public void SetUp()
        {
            driverBaseAction.GotoUrl(Constant.BASE_URL);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
