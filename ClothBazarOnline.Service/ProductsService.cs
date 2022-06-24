using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClothBazarOnline.Database;
using ClothBazarOnline.Entities;

namespace ClothBazarOnline.Service
{
  public  class ProductsService
    {

        public void Saveproduct(OProduct product )
        {
            using (var _Db = new CBContext())
            {

                _Db.OProducts.Add(product);
                _Db.SaveChanges();

            }

        }


        public List<OProduct> GetProduct()
        {
            using (var _Db = new CBContext())
            {



                return _Db.OProducts.ToList();
            }

        }


        public OProduct Getproduct (int ID)
        {
            using (var _db = new CBContext())
            {
                return _db.OProducts.Where( x =>x.ID == ID).FirstOrDefault(); 

            }
                       
        }



        public void DeleteProduct(OProduct product)
        {
            using (var _Db = new CBContext())
            {

                _Db.OProducts.Remove(product);
                _Db.SaveChanges();

            }

        }

        public void UpdateProduct(OProduct product)
        {
            using (var _Db = new CBContext())
            {

                _Db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                _Db.SaveChanges();

            }

        }


    }
}
