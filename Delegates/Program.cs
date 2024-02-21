using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //public delegate void PrintName(string name);

    internal class Program
    {
        public delegate bool IsEmployeePromotable(Employee emp);

        static void Main(string[] args)
        {
            //PrintName delPrint = new PrintName(PrintWelcomeMessage);

            //delPrint("WelCome Message");

            var listEmp = new List<Employee>();

            listEmp.Add(new Employee() { Experience = 6 });
            listEmp.Add(new Employee() { Experience = 1 });
            listEmp.Add(new Employee() { Experience = 3 });
            listEmp.Add(new Employee() { Experience = 8 });

            IsEmployeePromotable delPromote = new IsEmployeePromotable(IsEmployeeEligible);


            Employee.PromoteEmployee(listEmp, delPromote);

            Console.ReadLine();

        }



        //public static void PrintWelcomeMessage(string welcomeMessage) {

        //    Console.WriteLine(welcomeMessage);

        //}



        public static bool IsEmployeeEligible(Employee emp)
        {
             return emp.Experience > 6;
        }
    }
}
