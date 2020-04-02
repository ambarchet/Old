using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManagementTool.Data
{
   /*
    public enum SizeSelections { XXS = 1, XS, S, M, L, XL, XXL, R00, R0, R2, R4, R6, R8, R10, R12, R14, R16, S00, S0, S2, S4, S6, S8, S10, S12, S14, S16, L00, L0, L2, L4, L6, L8, L10, L12, L14, L16, W30xL30, W30xL32, W30xL34, W30xL36, W32xL30, W32xL32, W32xL34, W32xL36, W34xL30, W34xL32, W34xL34, W34xL36, W36xL30, W36xL32, W36xL34, W36xL36, W38xL30, W38xL32, W38xL34, W38xL36 }
    */
    public class Product
    {
        [Key]
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Display(Name = "Department")]
        [ForeignKey(nameof(ProductDepartment))]
        public int? ProductDepartmentId { get; set; }
        public virtual Department ProductDepartment { get; set; }

        [Required]
        [MinLength(7, ErrorMessage = "Style must be at least 7 characters long.")]
        [MaxLength(50, ErrorMessage = "There are too many characters in this field.")]
        public int Style { get; set; }

        [Required]
        [MinLength(7, ErrorMessage = "SKU must be at least 7 characters long.")]
        [MaxLength(50, ErrorMessage = "There are too many characters in this field.")]
        public int SKU { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Field must be at least 2 characters long.")]
        [MaxLength(10, ErrorMessage = "There are too many characters in this field.")]
        public int Color { get; set; }

        // public SizeSelections Size { get; set; }
        [Required]
        [Display(Name = "Size")]
        [ForeignKey(nameof(ProductSize))]
        public int? ProductSizeId { get; set; }
        public virtual Size ProductSize { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "Field must be at least 2 characters long.")]
        [MaxLength(50, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Ticket Price")]
        public decimal TicketPrice { get; set; }

        [Required]
        [Display(Name = "Sales Price")]
        public decimal SalesPrice { get; set; }

        [Display(Name = "Promotion")]
        [ForeignKey(nameof(ProductPromotion))]
        public int? ProductPromotionId { get; set; }
        public virtual Promotion ProductPromotion { get; set; }

        [Display(Name = "Zone Location")]
        [ForeignKey(nameof(ProductZone))]
        public int? ProductZoneId { get; set; }
        public virtual Zone ProductZone { get; set; }

        public int ZoneId { get; set; }
    }
}
