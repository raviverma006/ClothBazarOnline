using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClothBazarOnline.Database;
using ClothBazarOnline.Entities;

namespace ClothBazarOnline.Service
{
   public class CategoriesService
    {
        public void SaveCategory(OCategory category)
        {
            using (var _Db = new CBContext())
            {

                _Db.OCategories.Add(category);
                _Db.SaveChanges();

            }

        }


        public List<OCategory> GetCategory()
        {
            using (var _Db = new CBContext())
            {

                
                
                return _Db.OCategories.ToList();
            }

        }

    }
}
