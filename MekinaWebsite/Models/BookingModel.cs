using System;
using System.ComponentModel.DataAnnotations;

namespace MekinaWebsite.Models
{
    public class BookingModel
    {
        [Key]
        [Required]
        public long BookingId { get; set; }
        public string BookedCarName { get; set; }
        public string BookerName { get; set; }
        public DateTime? BookedDate { get; set; }
        public string PhoneNumber { get; set; }
        public long BookedCarId { get; set; }

    }
}
