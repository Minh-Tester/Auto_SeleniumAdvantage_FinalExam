using Automation_Test_Framework.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Test_Framework.TestSetData
{
    public class TestSetData_3
    {
        public List<EmployeesDAO> testRows = new List<EmployeesDAO>();


        public void CreateTestRows()
        {
            testRows.Add(new EmployeesDAO("Cierra", "Vega", "39", "cierra@example.com", "10000", "Insurance"));
            testRows.Add(new EmployeesDAO("Alden", "Cantrell", "45", "alden@example.com", "12000", "Compliance"));
            testRows.Add(new EmployeesDAO("Tony", "Tran", "22", "tonytran21092000@gmail.com", "1000", "Fresher"));
        }
    }
}
