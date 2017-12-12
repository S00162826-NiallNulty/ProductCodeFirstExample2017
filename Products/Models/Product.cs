using Products.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Products.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Product ID")]

        public int ProductId { get; set; }

        [ForeignKey("associatedCategory")]

        public int CategoryId { get; set; }

        public string Description { get; set; }

        [Column(TypeName ="date")]
        [Display(Name ="Date of Last Order")]

        public DateTime? LastOrderDate { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Date of first stocked")]

        public DateTime? FirstStockedOn { get; set; }
        [Display(Name = "Quantity in Stock")]

        public int QuantityInStock { get; set; }

        [Display(Name = "Unit Price")]

        public float UnitPrice { get; set; }
        public virtual Category associatedCategory { get; set; }
    }
}