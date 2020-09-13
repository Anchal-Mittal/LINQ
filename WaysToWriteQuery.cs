using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class WaysToWriteQuery
    {
        private static void QuerySyntax()
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var QuerySynatx = from ele in myList
                              where ele > 2
                              select ele;

            foreach (var item in QuerySynatx)
            {
                Console.WriteLine(item);
            }
        }

        private static void MethodSyntax()
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var MethodSyntax = myList.Where(ele => ele > 2);

            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item);
            }
        }

        private static void MixedSyntax()
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var MixedSynatx = (from ele in myList
                               select ele).Max();

            Console.WriteLine("Maximum Element of the list is: " + MixedSynatx);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Query Syntax");
            QuerySyntax();
            Console.WriteLine("Method Syntax");
            MethodSyntax();       
            Console.WriteLine("Mixed Syntax to find maximum element");
            MixedSyntax();
            Console.ReadKey();
        }
    }
}
