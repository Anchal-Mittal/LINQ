using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class IQueryableInterface
    {

        private static void UsedOfIqeryable()
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IQueryable<int> methodSyntax = myList.AsQueryable().Where(em => em > 5);
            foreach (int ele in methodSyntax)
            {
                Console.WriteLine(ele);
            }            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Used of IQueryable interface");
            UsedOfIqeryable();
            Console.ReadKey();
        }
    }
}
