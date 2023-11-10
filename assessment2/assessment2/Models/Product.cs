﻿using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace assessment2.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        //[Required(ErrorMessage = "The category name cannot be blank")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a category name between 3 and 50 characters in length")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Please enter a category name beginning with a capital letter and enter only letters and spaces.")]
        //[Display(Name="Product Name")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "The Product description cannot be blank")]
        //[StringLength(200, MinimumLength = 10, ErrorMessage = "Please enter a product description between 10 and 200 characters in length")] 
        //[RegularExpression(@"^[a-zA-Z0-9,\s]*$", ErrorMessage = "Please enter a product description made up of only letters, numbers and spaces")]
        public string Description { get; set; }

        //[Required(ErrorMessage = "The Product price cannot be blank")]
        //[Range(0.10, 10000, ErrorMessage = "Please enter a product price between 0.10 and 10000")]
        //[DataType(DataType.Currency)]
        //[DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}