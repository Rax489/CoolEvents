using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoolEvents.Data.Entities
{
    public class User : IdentityUser
    {

        [Required]
        public string FisrtName { get; set; }

        [Required]
        public string Surname { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
