namespace CFWithMigration
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public int id { get; set; }

        public string FristName { get; set; }

        public string LastName { get; set; }

        public string PhoneNo { get; set; }
    }
}
