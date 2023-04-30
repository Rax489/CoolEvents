using System.ComponentModel.DataAnnotations;

namespace CoolEvents.Data.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        public int EventId { get; set; }
        public int UserId { get; set; }
        public Event Event { get; set; }
        public User User { get; set; }
    }
}
