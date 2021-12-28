using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online.Models
{
    public class Store
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Store Name")]
        public string Store_Name { get; set; }
        public string Address { get; set; }
        public bool Master { get; set; }
        public int Serial_ADD { get; set; }
        public int Serial_Return { get; set; }
        public int Serial_Return_Sell { get; set; }
        public int Serial_Sell { get; set; }
        public int Serial_Transferin { get; set; }

        public int Serial_Transferout { get; set; }
        public int Serial_AddJ_Plus { get; set; }
        public int Serial_Addj_Discount { get; set; }

        public User User { get; set; }
        [Display(Name = "User Create")]
        [Required]
        public int UserId { get; set; }
        //[Required(ErrorMessage = "Enter the issued date.")]
        /// <summary>
        /// فى حاله الحذف يظهر الساعات والدقايق
        /// </summary>
        [DataType(DataType.Date)]

        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date_Record { get; set; }
        public bool ISdisable { get; set; }
        public DateTime? Modify_Date { get; set; }
        public User User_Modify { get; set; }
        public int? User_ModifyId { get; set; }
    }
}