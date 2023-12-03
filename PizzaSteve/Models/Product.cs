using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaSteve.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
      
        public Inventory Inventory { get; set; }
        public int InventoryId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
