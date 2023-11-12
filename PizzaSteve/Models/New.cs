namespace PizzaSteve.Models
{
    public class New
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CDate { get; set; } = DateTime.Now;
        public string Title { get; set; }
    }
}
