using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CFWithMigration
{
    public class BlogContext : DbContext
    {
       public DbSet<Blog> Blogs { get; set; }
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
   
}
