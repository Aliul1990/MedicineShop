using DrugHouse.Models;
using Med_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Med_Shop.Models.ViewModel;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Med_Shop.Controllers
{
    public class DrugsController : Controller
    {
        private readonly DrugDbContext db;
        private readonly IWebHostEnvironment _he;

        public DrugsController(DrugDbContext db, IWebHostEnvironment _he)
        {
            this.db = db;
            this._he = _he;
        }

        public async Task<IActionResult> Index(int page, string ShortBy, string Text)
        {
            //List<Medicine> modelData;
            ViewBag.sword = Text;
            ViewBag.ShortNameParam = string.IsNullOrEmpty(ShortBy) ? "Name-Desc" : "";
            ViewBag.ShortGenParam = ShortBy == "Generic" ? "Generic-Desc" : "Generic";
            ViewBag.ShortProvParam = ShortBy == "Provider" ? "Provider-Desc" : "Provider";
            IQueryable<Medicine> modelData = db.Medicine;
            if (!string.IsNullOrEmpty(Text))
            {
                Text = Text.ToLower();

                modelData = modelData.Where(
                    m => m.MedicineName.ToLower().Contains(Text) ||
                    //Need To add Seperate Parametar and Method for ID Scarch
                    m.MedicineID.Equals(Text) ||
                m.Generic.GenericName.ToLower().Contains(Text) ||
                 m.Provider.ProviderName.ToLower().Contains(Text)
                );
            }
            switch (ShortBy)
            {
                case "Name-Desc":
                    modelData = modelData.OrderByDescending(x => x.MedicineName);
                    break;

                case "Generic":
                    modelData = modelData.OrderBy(x => x.Generic.GenericName);
                    break;

                case "Generic-Desc":
                    modelData = modelData.OrderByDescending(x => x.Generic.GenericName);
                    break;

                case "Provider":
                    modelData = modelData.OrderBy(x => x.Provider.ProviderName);
                    break;

                case "Provider-Desc":
                    modelData = modelData.OrderByDescending(x => x.Provider.ProviderName);
                    break;

                default:
                    modelData = modelData.OrderBy(x => x.MedicineName);
                    break;
            }

            ViewBag.Gen = db.Generic.ToList();
            ViewBag.Prov = db.Provider.ToList();
            if (page <= 0) page = 1;
            int pageSize = 5;
            ViewBag.pSize = pageSize;
            ViewBag.Count = modelData.Count();

            Medicine medicine = new Medicine();
            return View(await PaginatedList<Medicine>.CreateAsync(modelData, page, pageSize));
        }

        public IActionResult Create()
        {
            ViewBag.Gen = db.Generic.ToList();
            ViewBag.Prov = db.Provider.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(MedicineVM medicineVM)
        {
            ViewBag.Gen = db.Generic.ToList();
            ViewBag.Prov = db.Provider.ToList();
            if (ModelState.IsValid)
            {
                string uniqfilename = "";
                if (medicineVM.Picture != null)
                {
                    string foldername = Path.Combine(_he.WebRootPath, "Images");
                    uniqfilename = Guid.NewGuid().ToString() + "_" + medicineVM.Picture.FileName;
                    string filePath = Path.Combine(foldername, uniqfilename);
                    medicineVM.Picture.CopyTo(new FileStream(filePath, FileMode.Create));

                    Medicine medicine = new Medicine
                    {
                        MedicineName = medicineVM.MedicineName,
                        TreadPrice = medicineVM.TreadPrice,
                        MRP = medicineVM.MRP,
                        StoredDate = DateTime.Now,
                        ExpirationDate = DateTime.Now.AddYears(3),
                        Quantity = medicineVM.Quantity,
                        GenericID = medicineVM.GenericID,
                        ProviderID = medicineVM.ProviderID,
                        PicturePath = uniqfilename
                    };
                    db.Medicine.Add(medicine);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(medicineVM);
        }

        public IActionResult Edit(int? id)
        {
            Medicine med = db.Medicine.Find(id);
            MedicineVM medvm = new MedicineVM
            {
                MedicineID = med.MedicineID,
                MedicineName = med.MedicineName,
                TreadPrice = med.TreadPrice,
                MRP = med.MRP,
                Quantity = med.Quantity,
                StoredDate = med.StoredDate,
                ExpirationDate = med.ExpirationDate,
                ProviderID = med.ProviderID,
                GenericID = med.GenericID,
                PicturePath = med.PicturePath
            };
            ViewBag.id = med.MedicineID;
            ViewBag.Gen = db.Generic.ToList();
            ViewBag.Prov = db.Provider.ToList();
            return View(medvm);
        }

        [HttpPost]
        public ActionResult Edit(MedicineVM medicineVM)
        {
            if (ModelState.IsValid)
            {
                string filePathOld = medicineVM.PicturePath;
                string uniqfilename = "";
                if (medicineVM.Picture != null)
                {
                    string foldername = Path.Combine(_he.WebRootPath, "Images");
                    uniqfilename = Guid.NewGuid().ToString() + "_" + medicineVM.Picture.FileName;
                    string filePath = Path.Combine(foldername, uniqfilename);
                    medicineVM.Picture.CopyTo(new FileStream(filePath, FileMode.Create));
                    Medicine medicine = new Medicine

                    {
                        MedicineID = medicineVM.MedicineID,
                        MedicineName = medicineVM.MedicineName,
                        TreadPrice = medicineVM.TreadPrice,
                        MRP = medicineVM.MRP,
                        Quantity = medicineVM.Quantity,
                        StoredDate = medicineVM.StoredDate,
                        ExpirationDate = medicineVM.ExpirationDate,
                        GenericID = medicineVM.GenericID,
                        ProviderID = medicineVM.ProviderID,
                        PicturePath = uniqfilename
                    };
                    db.Entry(medicine).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    Medicine med = new Medicine
                    {
                        MedicineID = medicineVM.MedicineID,
                        MedicineName = medicineVM.MedicineName,
                        TreadPrice = medicineVM.TreadPrice,
                        MRP = medicineVM.MRP,
                        Quantity = medicineVM.Quantity,
                        StoredDate = medicineVM.StoredDate,
                        ExpirationDate = medicineVM.ExpirationDate,
                        GenericID = medicineVM.GenericID,
                        ProviderID = medicineVM.ProviderID,
                        PicturePath = filePathOld
                    };
                    db.Entry(med).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Gen = new SelectList(db.Generic, "GenericID", "GenericName");
            ViewBag.Prov = new SelectList(db.Provider, "ProviderID", "ProviderName");
            return View(medicineVM);
        }

        public ActionResult Delete(int id)
        {
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
            return View(db.Medicine.First(x => x.MedicineID == id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteMed(int id)
        {
            var med = new Medicine { MedicineID = id };

            db.Entry(med).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Drugs");
        }
    }
}