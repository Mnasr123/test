using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online.Models
{
    public class Description_N1
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description_N1_Name { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime Date_Record { get; set; }
        public bool ISdisable { get; set; }
        public DateTime? Modify_Date { get; set; }
        
        public User User_Modify { get; set; }
        public int? User_ModifyId { get; set; }
    }
}