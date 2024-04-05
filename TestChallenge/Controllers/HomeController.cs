using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TestChallenge.Data;
using TestChallenge.Models;

namespace TestChallenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositoryContext _repo;

        public HomeController(ILogger<HomeController> logger,RepositoryContext context)
        {
            _logger = logger;
            _repo = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Shop()
        {
          

            var products = _repo.Products.ToList();
            var shopViewModel = new ShopViewModel();
            if (products != null)
            {
                foreach (var item in products)
                {
                    var productModel = new ProductModel
                    {
                        ProductId = item.Id,
                        ProductName = item.ProductName,
                        Cost = item.Cost,
                    };
                    shopViewModel.Products.Add(productModel);
                }
            }


            return View(shopViewModel);
        }
    }
}
