using Microsoft.AspNetCore.Identity;

namespace PizzaSteve.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       public byte[] ProfilePicture { get; set; }
        public string City { get; set; }
    }
}
