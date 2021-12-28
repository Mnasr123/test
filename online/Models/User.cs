using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string User_Name { get; set; }
        public string Passward { get; set; }
        public string Name { get; set; }
        public bool Isadmin { get; set; }
        public string Email { get; set; }
        public bool ISConfirm { get; set; }
        public int ?User_Confirm { get; set; }
        public DateTime ?Date_Confirm { get; set; }
        public int ?User_Id { get; set; }
        public DateTime Date_Record { get; set; }
        public bool ISdisable { get; set; }
        public DateTime? Modify_Date { get; set; }
        public int? User_Modify { get; set; }
        public string Image { get; set; }
    }
}