using ClothBazarOnline.Entities;
using ClothBazarOnline.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ClothBazarOnline.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categoryServices = new CategoriesService();
        // GET: /Category/Create


        [HttpGet]
        public ActionResult Index()
        {
            var  CategoriesList = categoryServices.GetCategory();
            return View(CategoriesList);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(OCategory oCategory)
        {
            categoryServices.SaveCategory(oCategory);


            return View();
        }

    }
}