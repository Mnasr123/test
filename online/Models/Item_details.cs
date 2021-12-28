﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online.Models
{
    public class Item_details
    {
        public int ID { get; set; }
        public Item Item { get; set; }
        public int ItemId { get; set; }
        public bool ISdisable { get; set; }
        public int Qty { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public int FirstQty { get; set; }
        public Store Store { get; set; }
        public int? StoreId { get; set; }
        public string Img_Path { get; set; }
        public string Offers_type { get; set; }
        public string Class_Offers { get; set; }
        public User User_Account { get; set; }
        [Display(Name = "User Create")]
        [Required]
        public int UserId { get; set; }
        public Description_N1 Description_N1 { get; set; }
        public int Description_N1Id { get; set; }
        public Description_N2 Description_N2 { get; set; }
        public int? Description_N2Id { get; set; }
        public Description_N3 Description_N3 { get; set; }
        public int? Description_N3Id { get; set; }
        public DateTime? Date_Record { get; set; }
    }
}