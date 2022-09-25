using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MekinaWebsite.Models
{
    public class CarsList
    {
        [Key]
        [Required]
        public long CarId { get; set; }
        [Required(ErrorMessage = "This information is required")]
        public string CarName { get; set; }
        [Required(ErrorMessage = "This information is required")]
        public decimal? Price { get; set; }
        public string Mileage { get; set; }
        public string PhoneNumber { get; set; }
        public string CarStatus { get; set; }
        public DateTime? CarYear { get; set; }
        public string Transmission { get; set; }
        public string CarImage { get; set; }
        public virtual ICollection<BookingModel> bookModel { get; set; }
    }
}
