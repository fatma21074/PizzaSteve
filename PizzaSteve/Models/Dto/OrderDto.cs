namespace PizzaSteve.Models.Dto
{
    public class OrderDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string UserName { get; set; }
    }
}
