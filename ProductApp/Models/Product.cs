namespace ProductApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int SubCategoryID { get; set; }
        public string ProductName { get; set; }
       
        public string Description { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
