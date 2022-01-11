using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_OPERATIONS__151.Models
{
    public class OrderModel
    {
        [Key]
        [Required(ErrorMessage = "Name of Item is Must Required.")]
        [MaxLength(20, ErrorMessage = "Maximum 20 Characters are Allowed..")]
        [MinLength(3, ErrorMessage = "Minimum 3 Characters are Must.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name of Item is Must Required.")]
        public string Descirption { get; set; }



        [Required(ErrorMessage = "Name of Item is Must Required.")]
       
        public string Quatity { get; set; }


        [Required(ErrorMessage = "Name of Item is Must Required.")]
        public int Price { get; set; }

        



    }
}
