using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazarOnline.Entities
{
  public  class OProduct : BaseEntity
    {
        public Decimal  Price { get; set; }
        public OCategory OCategories { get; set; }

    }
}
