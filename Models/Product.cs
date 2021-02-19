namespace HelloWorldAspNetMVC.Models
{
    public class Product
    {
        public int id { get; set; }
        public string description { get; set; }
        public int amount { get; set; }
        public int categoryId { get; set; }
        public Category Category {get; set; }
    }
}
