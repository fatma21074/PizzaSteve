using System.ComponentModel.DataAnnotations;

namespace PizzaSteve.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string message { get; set; }
        public string Subject { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
