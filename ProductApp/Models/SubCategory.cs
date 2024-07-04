namespace ProductApp.Models
{
    public class SubCategory
    {
        public int SubCategoryID { get; set; }
        public int CategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public Category Category { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
