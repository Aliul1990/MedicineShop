using DrugHouse.Models;
using Med_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Med_Shop.Controllers
{
    public class GenericController : Controller
    {
        private readonly DrugDbContext db;

        public GenericController(DrugDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(int page, string ShortBy, string Text)
        {
            ViewBag.sword = Text;
            ViewBag.ShortNameParam = string.IsNullOrEmpty(ShortBy) ? "Name-Desc" : "";
            IQueryable<Generic> modelData = db.Generic;
            if (!string.IsNullOrEmpty(Text))
            {
                Text = Text.ToLower();
                modelData = modelData.Where(m => m.GenericName.ToLower().Contains(Text));
            }
            switch (ShortBy)
            {
                case "Name-Desc":
                    modelData = modelData.OrderByDescending(x => x.GenericName);
                    break;

                default:
                    modelData = modelData.OrderBy(x => x.GenericName);
                    break;
            }
            if (page <= 0) page = 1;
            int pageSize = 5;
            ViewBag.pSize = pageSize;
            ViewBag.Count = modelData.Count();
            return View(await PaginatedList<Generic>.CreateAsync(modelData, page, pageSize));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Generic gen)
        {
            if (ModelState.IsValid)
            {
                db.Generic.Add(gen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(db.Generic.First(x => x.GenericID == id));
        }

        [HttpPost]
        public IActionResult Edit(Generic gen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gen).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gen);
        }

        public IActionResult Delete(int id)
        {
            return View(db.Generic.First(x => x.GenericID == id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteGeneric(int id)
        {
            var Gen = new Generic { GenericID = id };
            db.Entry(Gen).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}