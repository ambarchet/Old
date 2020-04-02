using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManagementTool.Models.Product
{
    public class ProductDetail
    {
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Display(Name = "Department")]
        public string DepartmentNumber { get; set; }

        public int Style { get; set; }

        public int SKU { get; set; }

        public int Color { get; set; }

        public string Size { get; set; }

        [Display(Name = "Name")]
        public string ProductName { get; set; }

        [Display(Name = "Ticket Price")]
        public decimal TicketPrice { get; set; }

        [Display(Name = "Promotion")]
        public string PromotionDescription { get; set; }

        [Display(Name = "Sales Price")]
        public decimal SalesPrice { get; set; }

        [Display(Name = "Zone")]
        public string ZoneName { get; set; }

    }
}
