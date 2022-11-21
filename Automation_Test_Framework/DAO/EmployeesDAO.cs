using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Test_Framework.DAO
{
    public class EmployeesDAO
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Email { get; set; }
       public string Age { get; set; }
       public string Salary { get; set; }
       public string Department { get; set; }

        public EmployeesDAO(string firstName, string lastName, string email, string age, string salary, string department)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Age = age;
            this.Salary = salary;
            this.Department = department;
        }

        public sealed class RecordRowComparator : Comparer<EmployeesDAO>
        {
            public override int Compare(EmployeesDAO? x, EmployeesDAO? y)
            {
                var compareResult = String.Equals(x?.FirstName, y?.FirstName) &&
                    String.Equals(x?.LastName, y?.LastName) &&
                    String.Equals(x?.Age, y?.Age) &&
                    String.Equals(x?.Email, y?.Email) &&
                    String.Equals(x?.Salary, y?.Salary) &&
                    String.Equals(x?.Department, y?.Department);
                if (compareResult)
                {
                    return 0;
                }
                return 1;
            }
        }
    }
}
