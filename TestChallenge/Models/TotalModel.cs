namespace TestChallenge.Models
{
    public class TotalModel
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public double TotalAmount { get; set; }
        public double Cash { get; set; }
        public double Change { get; set; }
    }
}
