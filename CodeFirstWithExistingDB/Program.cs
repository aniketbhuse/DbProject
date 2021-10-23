using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithExistingDB
{
    class Program
    {
        static void Main(string[] args)

        {
      
            using (simpleDBModel dbcontext = new simpleDBModel())
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                var customer = dbcontext.Customers.Where(c => c.FirstName.Contains("m")).ToList();
                customer.ForEach(c =>
                {
                    var orders = c.Orders.Where(o => o.TotalAmount > 100).ToList();
                });
                Console.WriteLine(watch.Elapsed.TotalMilliseconds);
                watch.Reset();
                watch.Start();
                var cuts = dbcontext.Customers.Include("Orders").Where(c => c.FritName);
            }
        }
    }
}
