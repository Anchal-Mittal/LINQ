using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    class Employee
    {
        public String Name { get; set; }
        public int Eid { get; set; }
    }

    class IEnumerable
    {
        private static List<Employee> GetEmployees()
        {
            List<Employee> empList = new List<Employee>();
            Employee empAnchal = new Employee();
            empAnchal.Name = "Anchal Mittal";
            empAnchal.Eid = 1303;
            empList.Add(empAnchal);

            Employee empPriyanka = new Employee();
            empPriyanka.Name = "Priyanka Goel";
            empPriyanka.Eid = 1304;
            empList.Add(empPriyanka);
            return empList;
        }


        private static void UsedOfGenericIEnumerable()
        {
            List<Employee> employees = GetEmployees();

            // query Syantx
            Console.WriteLine("Query Syntax");
            IEnumerable<Employee> querySyntax = from emp in employees
                                                where emp.Eid == 1304
                                                select emp;

            foreach (Employee em in querySyntax)
            {
                Console.WriteLine("Employee name " + em.Name + " Employee id " + em.Eid);
            }


            // method Syntax
            Console.WriteLine("Method Syntax");
            IEnumerable<Employee> methodSyntax = employees.Where(em => em.Eid == 1304);
            foreach (Employee em in methodSyntax)
            {
                Console.WriteLine("Employee name " + em.Name + " Employee id " + em.Eid);
            }

        }

        private static void UsedOfIEnumerable()
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Query Syntax
            Console.WriteLine("Query Syntax");
            IEnumerable<int> querySyntax = from element in myList
                                           where element > 7
                                           select element;


            foreach (int val in querySyntax)
            {
                Console.WriteLine(val);
            }

            // Method Syntax
            Console.WriteLine("Method Syntax");
            IEnumerable<int> methodSyntax = myList.Where(element => element > 7);

            foreach (int val in methodSyntax)
            {
                Console.WriteLine(val);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Used of IEnumerable Generic IEnumerable<T> ");
            UsedOfGenericIEnumerable();

            Console.WriteLine("Used of IEnumerable ");
            UsedOfIEnumerable();

            Console.ReadKey();
        }

     }
}
