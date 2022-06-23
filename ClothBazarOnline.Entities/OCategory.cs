using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazarOnline.Entities
{
   public class OCategory : BaseEntity
    {


        public List<OProduct> OProducts { get; set; }

    }
}
