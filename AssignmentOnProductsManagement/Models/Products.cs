using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AssignmentOnProductsManagement.Models
{
    public class Products
    {
        [Required(ErrorMessage = "ID Required")]
        public int Pid { get; set; }
        [Required(ErrorMessage = "Name Required")]
        public string Pname { get; set; }
        [Required(ErrorMessage = "Invalid")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Invalid")]
        public int Stock { get; set; }


    }
}
