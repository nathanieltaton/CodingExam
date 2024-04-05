using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestChallenge.Models
{
    public class ShopViewModel
    {
        public List<ProductModel> Products { get; set; }
        public ShopViewModel()
        {
            Products = new List<ProductModel>();
        }
    }
}
