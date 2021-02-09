using Microsoft.AspNetCore.Mvc;
using MyTest.Services;
using MyTest.Models;


namespace MyTest.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Created()
        {
            return View();
        }
        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Created(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

    }
}
