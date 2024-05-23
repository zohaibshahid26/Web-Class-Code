namespace WebApplication5.Models
{
    public class Cart
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; } = string.Empty;
        public string ProductCategory { get; set; }
        public decimal Price { get; set; }
    }
}
