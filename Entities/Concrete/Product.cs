using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        [Key]
        public int  ProductId { get; set; }

        [Required(ErrorMessage = "Please enter the product name")]
        public string  ProductName { get; set; }

        [Required(ErrorMessage = "Please enter the product code")]
        public string  ProductCode { get; set; }

        [Required(ErrorMessage = "Please enter the product explain")]
        public string  Explain { get; set; }

        [Required(ErrorMessage = "Please enter the product price")]
        public decimal  Price { get; set; }

        [Required(ErrorMessage = "Please enter how many pieces are in stock.")]
        public int  InStock { get; set; }

        public DateTime? DateTime { get; set; }
    }
}
