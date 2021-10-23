using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFristSimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TraderContext dbContext = new TraderContext())
            {
                var customer =  dbContext.Customers.ToList();

            }
            Console.ReadLine();
        }
    }
}
