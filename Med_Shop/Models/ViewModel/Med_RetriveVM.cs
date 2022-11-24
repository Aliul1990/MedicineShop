using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Med_Shop.Models.ViewModel
{
    public class Med_RetriveVM
    {
        public int MedicineID { get; set; }

        [Required, StringLength(50), Display(Name = "Medicine Name")]
        public string MedicineName { get; set; }

        [Required, Column(TypeName = "money"), DisplayFormat(DataFormatString = "{0:0.00}")]
        public decimal TreadPrice { get; set; }

        [Required, Column(TypeName = "money"), DisplayFormat(DataFormatString = "{0:0.00}")]
        public decimal MRP { get; set; }

        [Required, Column(TypeName = "date"), Display(Name = "Store Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StoredDate { get; set; }

        [Required, Column(TypeName = "date"), Display(Name = "Expiration Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpirationDate { get; set; }

        [Required, Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Picture")]
        public string PicturePath { get; set; }

        [Display(Name = "Generic")]
        public int GenericID { get; set; }

        [StringLength(50), Display(Name = "Generic")]
        public string GenericName { get; set; }

        [Display(Name = "Provider")]
        public int ProviderID { get; set; }

        [StringLength(50), Display(Name = "Provider")]
        public string ProviderName { get; set; }
    }
}