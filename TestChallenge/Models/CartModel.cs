namespace TestChallenge.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
    }
}
