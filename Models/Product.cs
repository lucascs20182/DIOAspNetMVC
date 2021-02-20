using System.ComponentModel.DataAnnotations;

namespace HelloWorldAspNetMVC.Models
{
    public class Product
    {
        public int id { get; set; }

        [Display(Name = "Descrição")]
        public string description { get; set; }

        [Display(Name = "Quantidade")]
        [Range(1, 10, ErrorMessage = "A qtd. máxima permitida é 10 e a mínima, 1.")]
        public int amount { get; set; }

        public int categoryId { get; set; }

        [Display(Name = "Categoria")]
        public Category Category {get; set; }
    }
}
