using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Med_Shop.Models;
using DrugHouse.Models;
using Microsoft.AspNetCore.Http;

namespace Med_Shop.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly DrugDbContext db;

        public ExpenseController(DrugDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(int page, string Text)
        {
            ViewBag.sword = Text;
            IQueryable<Expense> modelData = db.Expense;
            if (!string.IsNullOrEmpty(Text))
            {
                Text = Text.ToLower();

                modelData = modelData.Where(
                    m => m.User.ToLower().Contains(Text) ||
                    //Need To add Seperate Parametar and Method for ID Scarch
                    m.Details.ToLower().Contains(Text) ||
                    m.DateTime.Equals(Text)
                );
            }
            modelData = modelData.OrderByDescending(x => x.ExpenseID);

            //var Provier = db.Provider.ToList().ToPagedList(page ?? 1, 9);
            if (page <= 0) page = 1;
            int pageSize = 5;
            ViewBag.pSize = pageSize;
            ViewBag.Count = modelData.Count();
            return View(await PaginatedList<Expense>.CreateAsync(modelData, page, pageSize));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                string user = (string)TempData["User"];
                Expense exp = new Expense()
                {
                    ExpenseID = expense.ExpenseID,
                    User = user,
                    Cost = expense.Cost,
                    Details = expense.Details,
                    DateTime = DateTime.Now
                };
                //HttpContext.Session.
                db.Expense.Add(exp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(db.Expense.First(x => x.ExpenseID == id));
        }

        [HttpPost]
        public IActionResult Edit(Expense exp)
        {
            if (ModelState.IsValid)
            {
                string user = (string)TempData["User"];
                Expense expense = new Expense
                {
                    ExpenseID = exp.ExpenseID,
                    Cost = exp.Cost,
                    User = exp.User + "=>" + user,
                    Details = exp.Details,
                    DateTime = exp.DateTime
                };
                db.Entry(expense).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exp);
        }

        public IActionResult Delete(int id)
        {
            return View(db.Expense.First(x => x.ExpenseID == id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteProvider(int id)
        {
            var exp = new Expense { ExpenseID = id };
            db.Entry(exp).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}