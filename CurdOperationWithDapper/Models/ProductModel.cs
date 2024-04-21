using System.ComponentModel.DataAnnotations;
namespace CrudOperationWithDapper.Models

{
    public class ProductModel
    {
        public Guid ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
