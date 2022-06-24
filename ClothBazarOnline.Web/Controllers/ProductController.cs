using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothBazarOnline.Entities;
using ClothBazarOnline.Service;

namespace ClothBazarOnline.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService prod = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable()
        {
            var products = prod.GetProduct();

            return PartialView(products);
        }

        [HttpPost]
        public ActionResult ProductTable(string Search)
        {
            var products = prod.GetProduct().Find(x => x.Name == Search);

            return PartialView(products);
        }


        [HttpGet]
        public ActionResult CreateProduct()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct( OProduct product)
        {

                prod.Saveproduct(product);

          return  RedirectToAction("ProductTable");
        }


        [HttpGet]
        public ActionResult Edit(int ID)
        {


            return RedirectToAction("CreateProduct");
        }

        [HttpPost]
        public ActionResult Edit(OProduct product)
        {

            prod.UpdateProduct(product);

            return RedirectToAction("ProductTable");
        }



    }
}