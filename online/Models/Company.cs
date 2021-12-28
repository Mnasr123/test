using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online.Models
{
    public class Company
    {
        public int ID { get; set; }

        [Display(Name = "Company name")]
        //[ValidationCompany]
        public string Company_name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tele { get; set; }
        public string Mobile { get; set; }
        [Display(Name = "Comertial Register")]
        public string ComertialRegister { get; set; }
        [Display(Name = "Tax Register")]
        public string Tax_Register { get; set; }
        [Display(Name = "Social Num")]
        public string Socialnum { get; set; }
        public Company_Type Comp_Type { get; set; }

        [Display(Name = "Company Type")]
        public int Comp_TypeId { get; set; }
        public Company_Work Company_Work { get; set; }
        public int Company_WorkId { get; set; }
        public string Image { get; set; }
        public bool Master { get; set; }
        public string Web { get; set; }
        public string Fax { get; set; }
        public string Post_email { get; set; }
        public string Passward { get; set; }
        public string Manager_Name { get; set; }
        public string Manager_address { get; set; }
        public string Idtax { get; set; }
        public string Host { get; set; }
        public string Postcode { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public bool Isavaliable { get; set; }
        public System.DateTime Date { get; set; }
    }
}