using System.ComponentModel.DataAnnotations.Schema;

namespace TestChallenge.Data
{
    public class Total
    {
        [Column("TotalId")]
        public int Id { get; set; }
        public double TotalAmount { get; set; }
        public double Cash { get; set; }
        public double Change { get; set; }

        [ForeignKey("CheckoutId")]
        public int CheckoutId { get; set; }
    }
}
