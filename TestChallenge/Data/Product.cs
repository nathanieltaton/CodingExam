using System.ComponentModel.DataAnnotations.Schema;

namespace TestChallenge.Data
{
    public class Product
    {
        [Column("ProductId")]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Cost { get; set; }
    }
}
