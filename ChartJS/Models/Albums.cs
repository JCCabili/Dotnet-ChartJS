using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChartJS.Models
{
    public class Albums
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime SoldDate { get; set; }
    }
}