using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonicaBiler.Models.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Type { get; set; }  // e.g., Personvogn
        public string ModelName { get; set; } // Add this for the car's model name
        public int Year { get; set; }  // Årgang
        public DateTime FirstRegistration { get; set; }  // 1. reg
        public int Kilometers { get; set; }  // Km
        public string FuelType { get; set; }  // Brændstoftype
        public decimal FuelConsumption { get; set; }  // Km/ltr
        public decimal GreenOwnershipTax { get; set; }  // Grøn ejerafgift
        public decimal EngineSize { get; set; }  // Motor
        public decimal Acceleration { get; set; }  // 0-100
        public int TopSpeed { get; set; }  // Topfart
        public int MaxTowingWeight { get; set; }  // Max. trækvægt m/bremse
        public decimal Price { get; set; }  // pris
        public string ImageUrl { get; set; }

        // Navigation property for associated images
        public List<CarImage> Images { get; set; } = new List<CarImage>();
    }

}
