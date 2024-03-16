namespace Hplus.Model
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        public string ProductDescription { get; set; } = string.Empty;
        [Required]
        public string BrandName { get; set; } = string.Empty;

        public decimal ProductPrice { get; set; }

    }
}
