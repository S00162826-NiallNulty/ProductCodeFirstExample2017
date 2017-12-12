using Products.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Products.Controllers
{
    [Table("Category")]

    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Category ID")]

        public int CategoryId { get; set; }

        [Display(Name = "Category Name")]

        public string CategoryName { get; set; }

        public virtual ICollection<Product> productsInCategory { get; set; }

    }
}