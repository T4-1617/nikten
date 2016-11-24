using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace new_web_demo.Models
{
    public class GuestResponse
    {
        [Required]
        public string Name { get; set; }

        public string Phone { get; set; }
    }
}