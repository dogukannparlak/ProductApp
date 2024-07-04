namespace ProductApp.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
