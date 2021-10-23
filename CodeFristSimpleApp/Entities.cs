using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFristSimpleApp
{
   public class Customer
    {
        public int id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }

        public string PhoneNo { get; set; }
    }
    public class CustRecord
    {
        public int id { get; set; }

        public string Loan { get; set; }

        public string Pf { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
    }
   
}
