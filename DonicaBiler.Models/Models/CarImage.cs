using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonicaBiler.Models.Models
{
    public class CarImage
    {
        public int CarImageId { get; set; }
        public int CarId { get; set; }  // Foreign key to Car
        public string ImageUrl { get; set; }

        // Navigation property back to Car
        public Car Car { get; set; }
    }

}
