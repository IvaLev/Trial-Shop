using System.Web.Mvc;
using Trial_Shop.Interfaces;
using Trial_Shop.Models;

namespace Trial_Shop.Controllers
{
    public class CartController : Controller
    {
        private IUow UoW { get; set; }

        public CartController(IUow uow)
        {
            UoW = uow;
        }
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateOrder(OrderModel order)
        {
            UoW.OrderRepository.CreateOrder(order);
            return View();
        }
    }
}