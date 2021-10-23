namespace CFWithMigration
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustRecord
    {
        public int id { get; set; }

        public string Loan { get; set; }

        public string Pf { get; set; }
    }
}
