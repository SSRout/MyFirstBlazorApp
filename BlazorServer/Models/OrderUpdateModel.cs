using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class OrderUpdateModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "max 20 char")]
        [MinLength(3, ErrorMessage = "min 3 char")]
        [DisplayName("Name For The Order")]
        public string OrderName { get; set; }
    }
}
