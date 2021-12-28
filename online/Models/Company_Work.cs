using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online.Models
{
    public class Company_Work
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Work Type")]
        public string Work_name { get; set; }
        public bool Isavaliable { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public System.DateTime Date { get; set; }
    }
}