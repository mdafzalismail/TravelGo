using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelGo_final.Model
{
    public class AddUser
    {
        [Key]
        [Required]
        public int uid { get; set; }

        public string uname { get; set; }

        public string address { get; set; }

        public string phone { get; set; }
    }
}
