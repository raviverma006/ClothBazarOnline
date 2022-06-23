using ClothBazarOnline.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazarOnline.Database
{
   public class CBContext :DbContext
    {
        public CBContext() : base("DBConnection")
        {
             
        }

         public DbSet<OProduct> OProducts { get; set; }
        public DbSet<OCategory> OCategories { get; set; }

    }
}
