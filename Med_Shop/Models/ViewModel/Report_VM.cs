using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Med_Shop.Models.ViewModel
{
    public class DayTotalVM
    {
        public int Day { get; set; }
        public decimal Total { get; set; }
    }

    public class SalesVM
    {
        public DateTime Date { get; set; }
        public List<DayTotalVM> Days { get; set; }
    }
}