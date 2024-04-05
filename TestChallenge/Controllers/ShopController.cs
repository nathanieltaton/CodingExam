using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestChallenge.Data;
using TestChallenge.Models;

namespace TestChallenge.Controllers
{
    public class ShopController : Controller
    {
        private readonly RepositoryContext _repo;

        public ShopController(RepositoryContext context)
        {
            _repo = context;
        }
        // GET: ShopController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/ShopController/GetProductDetails")]
        public ActionResult GetProductDetails(string productName)
        {
            var product = _repo.Database.SqlQuery<Product>($"Exec GetProductDetails {productName}").AsEnumerable().FirstOrDefault();
            if (product != null)
            {
                return Json(new { success = true, responseText = product });
            }
            return Json(new { success = false, responseText = "failed" });
        }


        [HttpPost("/ShopController/SaveCart")]
        public ActionResult SaveCart(string[] ProductName, int[] Quantity, double[] Cost, int[] ProductId, double Cash,double TotalAmount,double Change)
        {
            var checkoutId = _repo.Database.SqlQuery<int?>($"Exec [GetLastInsertedCheckoutId]").AsEnumerable().FirstOrDefault();
            var id = checkoutId != null ? Convert.ToInt32(checkoutId) + 1 : 1;
            for (int a = 0; a < ProductName.Count(); a++)
            {
                var cartToAdd = new Cart
                {
                    ProductName = ProductName[a],
                    Quantity = Quantity[a],
                    Cost = Cost[a],
                    ProductId = ProductId[a],
                    CheckoutId = id
                };
                _repo.Carts.Add(cartToAdd);
            }

            var totalToAdd = new Total
            {
                Cash = Cash,
                TotalAmount = TotalAmount,
                CheckoutId = id,
                Change = Change
            };

            _repo.Totals.Add(totalToAdd);
            _repo.SaveChanges();
            return Json(new { success = false, responseText = "failed" });
        }


        // GET: ShopController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
