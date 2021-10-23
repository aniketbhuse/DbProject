using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            using (simpleDBEntities1 dbContext = new simpleDBEntities1())
            {
                //1.Retrive data
                dbContext.Customers.ToList().ForEach(cus => {Console.WriteLine($"Name{cus.FirstName},Phone:{cus.Phone}");});
                //3. Create
                Customer createCustomer = new Customer();
                createCustomer.FirstName = "Vivek";
                createCustomer.LastName = "Shah";
                createCustomer.Phone = "9898855588";
                dbContext.Customers.Add(createCustomer);

                //4. Create Multiple
                Customer createCustomer1 = new Customer();
                createCustomer1.FirstName = "Jivan";
                createCustomer1.LastName = "Shah";
                createCustomer1.Phone = "333333333";
                Customer createCustomer2 = new Customer();
                createCustomer2.FirstName = "Jignesh";
                createCustomer2.LastName = "Shah";
                createCustomer2.Phone = "22222222";
                List<Customer> lstCustomers = new List<Customer>();
                lstCustomers.Add(createCustomer1);
                lstCustomers.Add(createCustomer2);
                dbContext.Customers.AddRange(lstCustomers);
                dbContext.SaveChanges();

                //5. Retrieve
                dbContext.Customers.ToList().ForEach(cus => { Console.WriteLine($"Name{ cus.FirstName}, Phone: { cus.Phone}"); });

                    //6. Update
                   //Customer cust = dbContext.Customers.Where(x => x.FirstName =="Vivek").FirstOrDefault();
                  // Address address = new Address()
                   // {
                       // City = "Mumbai",
                        //AddressType = 0,
                       // Address_One = "Address 1",
                       // Address_Two = "Address 2",
                        //Country = "India",
                       // State = "Gujarat"
                   // };
                //7. Retrieve specific record
               // var customer = dbContext.Customers.Where(cu => cu.Id ==2).SingleOrDefault();
               //Console.WriteLine($"Customer Name:{customer.FirstName},City:{ customer.Address.City}");
                //8. SQL Query
                var cust1 = dbContext.Customers.SqlQuery("SELECT * FROM Customer where id =1; ").SingleOrDefault();



                    //9. Lazy Loading
                var custFirst = dbContext.Customers.First();
                var orders = custFirst.Orders;

                //10 .Eager Loading
                var custFirstWithOrder =
                dbContext.Customers.Include("Orders.OrderItems").First();
                var orderItems = custFirstWithOrder.Orders.First().OrderItems.ToList();
                //11. Explicit loading
                var order = dbContext.Orders.Where(o => o.Id == 1).FirstOrDefault();
                dbContext.Entry(order).Collection(o => o.OrderItems).Load();
                //12. Extenstion methods. [First, FirstOrDefai, Single, SingleOrDefaul, Sum,Max, Average, Count, Last, ToList]
                   var orderFirst = dbContext.Orders.First();
                //var discountedAmount = orderFirst.GetDiscountedAmount();
                var average = dbContext.Customers.Average(c => c.Orders.Count);
                var count = dbContext.Customers.Count();
                //13. Group by, Order by
                var ordersGroupByCusrID = dbContext.Orders.GroupBy(o =>
               o.CustomerId).ToList();
                ordersGroupByCusrID.ForEach(x => {
                    Console.WriteLine($"CustomerID:{x.Key},having count of { x.Count()}"); });
                ordersGroupByCusrID.ForEach(x => {Console.WriteLine($"CustomerID:{x.Key}having count of { x.Sum(o => o.TotalAmount)}"); });
                var ordersOrderByAmount = dbContext.Orders.OrderByDescending(o =o.TotalAmount).ToList();
     
            }
            Console.ReadLine();
        }
    }
}
