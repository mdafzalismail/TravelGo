using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelGo_final.Model
{
    public class AddTrip
    {
        [Key]
        [Required]
        public int tid { get; set; }

        public string tname { get; set; }

        public string tdetails { get; set; }

        public string tseason { get; set; }

        public int tprice { get; set; }

        public int quantity { get; set; }
    }
}
