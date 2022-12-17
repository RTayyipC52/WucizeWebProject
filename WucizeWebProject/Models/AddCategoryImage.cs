namespace WucizeWebProject.Models
{
    public class AddCategoryImage
    {
        public string CategoryName { get; set; }

        public IFormFile CategoryImage { get; set; }

        public int ContentType { get; set; }

        public int Order { get; set; }

        public bool Status { get; set; }
    }
}
