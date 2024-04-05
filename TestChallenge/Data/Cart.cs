using System.ComponentModel.DataAnnotations.Schema;

namespace TestChallenge.Data
{
    public class Cart
    {
        [Column("CartId")]
        public int Id { get; set; }
        public int CheckoutId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }

    }
}
