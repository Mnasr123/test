using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace online.Models
{
    public class Group
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Group Name")]
        public string Group_Name { get; set; }
        public string Description_Data { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime Date_Record { get; set; }
        public bool ISdisable { get; set; }
        public DateTime? Modify_Date { get; set; }
        public  User User_Modify { get; set; }
        public int ?User_ModifyId { get; set; }
    }
}