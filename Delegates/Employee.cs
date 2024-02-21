using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates.Program;

namespace Delegates
{
   
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employees, IsEmployeePromotable delPromote)
        {
            foreach(Employee employee in employees)
            {
                if(delPromote(employee))
                {
                    Console.WriteLine("Promoted");
                }
            }
        }
    }
}
