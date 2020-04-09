using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TravelGo_final.Model
{
    public class feedBack
    {

        [Key]
        [Required]
        public int fid { get; set; }
        public string feedback { get; set; }
    }
}
