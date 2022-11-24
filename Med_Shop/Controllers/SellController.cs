using DrugHouse.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Med_Shop.Models.ViewModel;
using System.IO;

namespace Med_Shop.Controllers
{
    public class SellController : Controller
    {
        private readonly DrugDbContext db;

        public SellController(DrugDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index(string Text)
        {
            IQueryable<Medicine> modelData = db.Medicine;
            if (!string.IsNullOrEmpty(Text))
            {
                Text = Text.ToLower();

                modelData = modelData.Where(
                    m => m.MedicineID.Equals(Text) ||
                    m.MedicineName.ToLower().Contains(Text)
                );
            }
            else
            {
                modelData = modelData.OrderByDescending(x => x.MedicineName);
            }
            return View(modelData);
        }

        public IActionResult AddToQuaree(int mid, int qty)
        {
            bool itemFound = false;
            string msg = "";
            if (mid > 0)
            {
                if (qty == 0)
                {
                    msg = "Quantity can not be Ziro(0)";
                }
                else
                {
                    var prod = db.Medicine.FirstOrDefault(p => p.MedicineID == mid);
                    if (prod != null)
                    {
                        if (prod.ExpirationDate > DateTime.Now.AddMonths(-1))
                        {
                            List<Medicine> items = new List<Medicine>();
                            var xItems = HttpContext.Session.GetObject<List<Medicine>>("cart");
                            if (xItems != null)
                            {
                                foreach (var item in xItems)
                                {
                                    if (mid == item.MedicineID)
                                    {
                                        item.Quantity += qty;
                                        itemFound = true;
                                        msg = "Item was already added Quantity Updated";
                                    }
                                    items.Add(item);
                                }
                                if (!itemFound)
                                {
                                    prod.Quantity = qty;
                                    items.Add(prod);
                                    msg = "New Item is Added";
                                }
                                HttpContext.Session.SetObject<List<Medicine>>("cart", items);
                            }
                            else
                            {
                                prod.Quantity = qty;
                                items.Add(prod);
                                HttpContext.Session.SetObject<List<Medicine>>("cart", items);
                                msg = "Item Added For New Customer";
                            }
                        }
                        else
                        {
                            msg = "Date is Expired";
                        }
                    }
                    else
                    {
                        msg = "Item is not found!!!";
                    }
                }
            }
            else
            {
                msg = "Item Id could not be zero!!!";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Index");
        }

        public IActionResult Show()
        {
            List<SellVM> sellVM = new List<SellVM>();
            var items = HttpContext.Session.GetObject<List<Medicine>>("cart");
            foreach (var item in items)
            {
                sellVM.Add(new SellVM
                {
                    MedicineID = item.MedicineID,
                    MedicineName = item.MedicineName,
                    Quantity = item.Quantity,
                    MRP = (double)item.MRP,
                    Price = (double)(item.MRP * item.Quantity)
                });
            }
            if (sellVM != null && sellVM.Count != null)
            {
                return View(sellVM.ToList());
            }
            else
            {
                sellVM = new List<SellVM>();
                return View();
            }
        }

        public IActionResult RemoveFromCart(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            List<Medicine> productList = HttpContext.Session.GetObject<List<Medicine>>("cart");
            var removeItem = productList.FirstOrDefault(x => x.MedicineID == id);
            productList.Remove(removeItem);
            HttpContext.Session.SetObject<List<Medicine>>("cart", productList);

            return RedirectToAction(nameof(Show));
        }

        [HttpPost]
        public IActionResult SellVM(IEnumerable<SellVM> sellVM)
        {
            //List<Medicine> medicines = new List<Medicine>();
            string User = (string)TempData["User"];
            int amount = 0;
            string medicineid = "";
            foreach (var item in sellVM)
            {
                amount += (int)item.Price;
                medicineid += item.MedicineID + ",";
                Medicine medicine = db.Medicine.FirstOrDefault(f => f.MedicineID == item.MedicineID);
                int newQty = medicine.Quantity - item.Quantity;
                medicine.Quantity = newQty;
                db.SaveChanges();
                HttpContext.Session.Clear();
            }
            if (sellVM != null)
            {
                string substr = medicineid.Remove(medicineid.Length - 1, 1);
                Bill bill = new Bill()
                {
                    User = User,
                    Amount = amount,
                    DateTime = DateTime.Now,
                    MedicineID = substr
                };
                string billno = bill.BillID.ToString();
                db.Bill.Add(bill);
                db.SaveChanges();

                var fileName = @"C:\Users\Aliul\Desktop\Bills\" + DateTime.Now.ToLongDateString() + Guid.NewGuid().ToString() + ".pdf";
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine("                    Our Pharma");
                sw.WriteLine("                   Dept. of CSE");
                sw.WriteLine("           Dhaka International University");
                sw.WriteLine("                    Dhaka-1205");
                sw.Write("Medicines                ");
                sw.Write("MRP    ");
                sw.Write("Quantity   ");
                sw.WriteLine("SubTotal");
                double total = 0;
                foreach (var item in sellVM)
                {
                    int NameLength = item.MedicineName.Length;
                    if (NameLength <= 25)
                    {
                        int length = 25 - NameLength;
                        if (length == 0)
                        {
                            sw.Write(item.MedicineName);
                        }
                        if (length == 1)
                        {
                            sw.Write(item.MedicineName + " ");
                        }
                        if (length == 2)
                        {
                            sw.Write(item.MedicineName + "  ");
                        }
                        if (length == 3)
                        {
                            sw.Write(item.MedicineName + "   ");
                        }
                        if (length == 4)
                        {
                            sw.Write(item.MedicineName + "    ");
                        }
                        if (length == 5)
                        {
                            sw.Write(item.MedicineName + "     ");
                        }
                        if (length == 6)
                        {
                            sw.Write(item.MedicineName + "      ");
                        }
                        if (length == 7)
                        {
                            sw.Write(item.MedicineName + "       ");
                        }
                        if (length == 8)
                        {
                            sw.Write(item.MedicineName + "        ");
                        }
                        if (length == 9)
                        {
                            sw.Write(item.MedicineName + "         ");
                        }
                        if (length == 10)
                        {
                            sw.Write(item.MedicineName + "          ");
                        }
                        if (length == 11)
                        {
                            sw.Write(item.MedicineName + "           ");
                        }
                        if (length == 12)
                        {
                            sw.Write(item.MedicineName + "            ");
                        }
                        if (length == 13)
                        {
                            sw.Write(item.MedicineName + "             ");
                        }
                        if (length == 14)
                        {
                            sw.Write(item.MedicineName + "              ");
                        }
                        if (length == 15)
                        {
                            sw.Write(item.MedicineName + "               ");
                        }
                        if (length == 16)
                        {
                            sw.Write(item.MedicineName + "                ");
                        }
                        if (length == 17)
                        {
                            sw.Write(item.MedicineName + "                 ");
                        }
                        if (length == 18)
                        {
                            sw.Write(item.MedicineName + "                  ");
                        }
                        if (length == 19)
                        {
                            sw.Write(item.MedicineName + "                   ");
                        }
                        if (length == 20)
                        {
                            sw.Write(item.MedicineName + "                    ");
                        }
                        if (length == 21)
                        {
                            sw.Write(item.MedicineName + "                     ");
                        }
                        if (length == 22)
                        {
                            sw.Write(item.MedicineName + "                      ");
                        }
                        int mrplength = item.MRP.ToString().Length;
                        if (mrplength == 1)
                        {
                            sw.Write(item.MRP + "      ");
                        }
                        if (mrplength == 2)
                        {
                            sw.Write(item.MRP + "     ");
                        }
                        if (mrplength == 3)
                        {
                            sw.Write(item.MRP + "    ");
                        }
                        if (mrplength == 4)
                        {
                            sw.Write(item.MRP + "   ");
                        }
                        if (mrplength == 5)
                        {
                            sw.Write(item.MRP + "  ");
                        }
                        int qtylength = item.Quantity.ToString().Length;
                        if (qtylength == 1)
                        {
                            sw.Write(item.Quantity + "          ");
                        }
                        if (qtylength == 2)
                        {
                            sw.Write(item.Quantity + "         ");
                        }
                        if (qtylength == 3)
                        {
                            sw.Write(item.Quantity + "        ");
                        }
                        if (qtylength == 4)
                        {
                            sw.Write(item.Quantity + "       ");
                        }
                        if (qtylength == 5)
                        {
                            sw.Write(item.Quantity + "      ");
                        }
                    }
                    sw.WriteLine(item.Price);
                    total += item.Price;
                }
                sw.WriteLine("                                   Total = " + total);
                sw.WriteLine("Billed By: " + User);
                sw.Flush();
                sw.Close();
            }

            return RedirectToAction("Index");
        }
    }
}