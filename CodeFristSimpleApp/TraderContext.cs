using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFristSimpleApp
{
    public class TraderContext :DbContext
    {
        public TraderContext() : base("name = simpleDBEntitiesCF")
        {

        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustRecord> CustRecords { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
