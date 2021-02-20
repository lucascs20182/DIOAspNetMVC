using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldAspNetMVC.Models
{
    public class Category
    {
        public int id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição deve ser preenchido.")]
        public string description { get; set; }

        public List<Product> Products { get; set; }
    }
}
