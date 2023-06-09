﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shop_MahdiTaremi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }       
//[Required]
//[StringLength(50)]
        public int Price { get; set; }
        //[Required]
        public int Quantity { get; set; }   
        public string? Color { get; set; }
        public Boolean Status { get; set; }
        public string? pic_1 { get; set; }  
        //[Required(ErrorMessage = "Please select files")]
        [NotMapped]
        public IFormFile? UploadFile { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        [ForeignKey("BasketId")]
       public ICollection<Basket> IdBasket { get; set; }



    }
}
