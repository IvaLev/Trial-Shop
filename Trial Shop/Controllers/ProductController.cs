using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trial_Shop.Interfaces;

namespace Trial_Shop.Controllers
{
    public class ProductController : Controller
    {
        private IUow UoW { get; set; }

        public ProductController(IUow uow)
        {
            UoW = uow;
        }

        // GET: Product
        public ActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                var product = UoW.ProductRepository.GetProduct(id.Value);
                return View(product);
            }
            return View();
        }
    }
}