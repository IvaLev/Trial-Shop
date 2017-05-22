using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trial_Shop.Interfaces;
using Trial_Shop.ViewModels;

namespace Trial_Shop.Controllers
{
    public class HomeController : Controller
    {
        private IUow UoW { get; set; }

        public HomeController(IUow uow)
        {
            UoW = uow;
        }

        public ActionResult Index()
        {
            var model = new ProductsViewModel
            {
                Products = UoW.ProductRepository.GetAllProducts()
            };

            return View(model);
        }
    }
}