using System.ComponentModel.DataAnnotations;

namespace CoolEvents.Data.Entities
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [MaxLength(64)]
        public string EventName { get; set; }

        [Required]
        [MaxLength(255)]
        public string EventDescription { get; set; }

        [Required]
        public string imgUrl { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

    }
}
