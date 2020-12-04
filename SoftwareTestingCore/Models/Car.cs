using System;
using System.ComponentModel.DataAnnotations;

namespace SoftwareTestingCore.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public int PriceRange { get; set; }
    }

    public class CarViewModel {

        public int Notification { get; set; }

        public Car Car { get; set; }

    }
}
