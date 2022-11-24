using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Med_Shop.Models;
using DrugHouse.Models;

namespace Med_Shop.Controllers
{
    public class ProviderController : Controller
    {
        private readonly DrugDbContext db;

        public ProviderController(DrugDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(int page, string ShortBy, string Text)
        {
            ViewBag.sword = Text;
            ViewBag.ShortNameParam = string.IsNullOrEmpty(ShortBy) ? "Name-Desc" : "";
            IQueryable<Provider> modelData = db.Provider;
            if (!string.IsNullOrEmpty(Text))
            {
                Text = Text.ToLower();
                modelData = modelData.Where(m => m.ProviderName.ToLower().Contains(Text));
            }
            switch (ShortBy)
            {
                case "Name-Desc":
                    modelData = modelData.OrderByDescending(x => x.ProviderName);
                    break;

                default:
                    modelData = modelData.OrderBy(x => x.ProviderName);
                    break;
            }
            //var Provier = db.Provider.ToList().ToPagedList(page ?? 1, 9);
            if (page <= 0) page = 1;
            int pageSize = 5;
            ViewBag.pSize = pageSize;
            ViewBag.Count = modelData.Count();
            return View(await PaginatedList<Provider>.CreateAsync(modelData, page, pageSize));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Provider prov)
        {
            if (ModelState.IsValid)
            {
                db.Provider.Add(prov);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(db.Provider.First(x => x.ProviderID == id));
        }

        [HttpPost]
        public IActionResult Edit(Provider prov)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prov).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prov);
        }

        public IActionResult Delete(int id)
        {
            return View(db.Provider.First(x => x.ProviderID == id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteProvider(int id)
        {
            var prov = new Provider { ProviderID = id };
            db.Entry(prov).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}