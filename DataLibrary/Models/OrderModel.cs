using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLibrary.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20,ErrorMessage ="max 20 char")]
        [MinLength(3,ErrorMessage ="min 3 char")]
        [DisplayName("Name For The Order")]
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        [DisplayName("Meal")]
        [Range(1,int.MaxValue,ErrorMessage ="Select one")]
        public int FoodId { get; set; }
        [Required]
        [Range(1,10,ErrorMessage ="select up to 10")]
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
