namespace WucizeWebProject.Models
{
    public class AddProductImage
    {
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public IFormFile ProductImage { get; set; }
    }
}
