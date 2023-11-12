namespace PizzaSteve.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Admin Admin { get; set; }
        public int AdminId { get; set; }
    }
}
