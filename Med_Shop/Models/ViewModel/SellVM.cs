using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Med_Shop.Models.ViewModel
{
    public class SellVM
    {
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int Quantity { get; set; }
        public double MRP { get; set; }
        public double Price { get; set; }
    }
}