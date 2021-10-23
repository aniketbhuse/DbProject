namespace CFWithMigration
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderNumber { get; set; }

        public int CustomerId { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
