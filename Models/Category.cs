using System.Collections.Generic;

namespace HelloWorldAspNetMVC.Models
{
    public class Category
    {
        public int id { get; set; }
        public string description { get; set; }

        public List<Product> Products { get; set; }
    }
}
