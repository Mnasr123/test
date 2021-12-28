using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online.Models
{
    public class Company_Type
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Type name")]
        public string Type_name { get; set; }
        public bool Isavaliable { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public System.DateTime Date { get; set; }
    }
}