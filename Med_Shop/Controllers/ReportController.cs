using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Med_Shop.Models;
using DrugHouse.Models;
using Med_Shop.Models.ViewModel;

namespace Med_Shop.Controllers
{
    public class ReportController : Controller
    {
        private readonly DrugDbContext db;

        public ReportController(DrugDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index(DateTime? date)
        {
            if (date == null)
            {
                List<Expense> expence = db.Expense.Where(x => x.DateTime.Date == DateTime.Today).ToList();
                List<Bill> bills = db.Bill.Where(x => x.DateTime.Date == DateTime.Today).ToList();
                ViewData["Bills"] = bills;
                ViewData["Date"] = DateTime.Today.ToLongDateString();
                return View(expence);
            }
            if (date != null)
            {
                List<Expense> expence = db.Expense.Where(x => x.DateTime.Date == date).ToList();
                List<Bill> bills = db.Bill.Where(x => x.DateTime.Date == date).ToList();
                ViewData["Bills"] = bills;
                DateTime MsgDate = (DateTime)date;
                ViewData["Date"] = MsgDate.ToLongDateString();
                return View(expence);
            }

            return View();
        }

        public IActionResult MonthlyReport(int _year, int _month)
        {
            int year = 0, month = 0;
            if (_year != 0 && _month != 0)
            {
                year = _year;
                month = _month;
            }
            if (_year == 0 && _month == 0)
            {
                year = (int)DateTime.Now.Year;
                month = (int)DateTime.Now.Month;
            }
            int DaysInMonth = DateTime.DaysInMonth(year, month);

            var days = Enumerable.Range(1, DaysInMonth);
            var query = db.Bill.Where(x => x.DateTime.Year == year && x.DateTime.Month == month).Select(g => new
            {
                Day = g.DateTime.Day,
                Total = g.Amount
            });
            var model = new SalesVM
            {
                Date = new DateTime(year, month, 1),
                Days = days.GroupJoin(query, d => d, q => q.Day, (d, q) => new DayTotalVM
                {
                    Day = d,
                    Total = q.Sum(x => x.Total)
                }).ToList()
            };

            var query2 = db.Expense.Where(x => x.DateTime.Year == year && x.DateTime.Month == month).Select(g => new
            {
                Day = g.DateTime.Day,
                Total = g.Cost
            });
            var model2 = new SalesVM
            {
                Date = new DateTime(year, month, 1),
                Days = days.GroupJoin(query, d => d, q => q.Day, (d, q) => new DayTotalVM
                {
                    Day = d,
                    Total = q.Sum(x => x.Total)
                }).ToList()
            };

            ViewData["Bills"] = model;
            ViewData["Expences"] = model2;

            return View();
        }

        //public PartialViewResult Credit(DateTime? date)
        //{
        //    if (date == null)
        //    {
        //        List<Bill> bills = db.Bill.Where(x => x.DateTime.Date == date).ToList();
        //        return PartialView(bills);
        //    }
        //    if (date != null)
        //    {
        //        List<Expense> expence = db.Expense.Where(x => x.DateTime.Date == date).ToList();
        //        List<Bill> bills = db.Bill.Where(x => x.DateTime.Date == date).ToList();
        //        return PartialView(bills);
        //    }
        //    return PartialView();
        //}

        //public IActionResult Debit(DateTime? date)
        //{
        //List<Med_RetriveVM> data = (from m in db.Medicine
        //                            where (m.MedicineID == id)
        //                            join p in db.Provider on m.ProviderID equals p.ProviderID
        //                            join g in db.Generic on m.GenericID equals g.GenericID
        //                            select new Med_RetriveVM
        //                            {
        //                                MedicineID = m.MedicineID,
        //                                MedicineName = m.MedicineName,
        //                                TreadPrice = m.TreadPrice,
        //                                MRP = m.MRP,
        //                                StoredDate = m.StoredDate,
        //                                ExpirationDate = m.ExpirationDate,
        //                                PicturePath = m.PicturePath,
        //                                Quantity = m.Quantity,
        //                                GenericID = m.GenericID,
        //                                GenericName = g.GenericName,
        //                                ProviderID = m.ProviderID,
        //                                ProviderName = p.ProviderName
        //                            }).ToList();

        //IQueryable<Generic> modelData = db.Generic;
        //Medicine med = db.Medicine.Find(id);
        //modelData = modelData.Where(x => x.GenericID == med.GenericID);

        //return View(data);
        //List<Expense> expecnces = db.Expense.ToList();
        //foreach (var item in expecnces)
        //{
        //    item.Cost
        //    if (date == null)
        //    {
        //        date = DateTime.Today;
        //    }
        //    if (date != null)
        //    {
        //        List<Expense> expence = db.Expense.Where(x => x.DateTime.Date == date).ToList();
        //        double totalEnpence = 0;
        //        int ExpenceCount = 0;
        //        foreach (var item in expence)
        //        {
        //            totalEnpence += item.Cost;
        //            ExpenceCount += 1;
        //        }
        //        ViewBag.totalEnpence = totalEnpence;
        //        //ViewBag.expen
        //        List<Bill> bills = db.Bill.Where(x => x.DateTime.Date == date).ToList();
        //        double totalCollected = 0;
        //        int BillCount = 0;
        //        foreach (var item in bills)
        //        {
        //            totalCollected += item.Amount;
        //            BillCount += 1;
        //        }
        //        return View("_Debit");
        //    }
        //}
    }
}