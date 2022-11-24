using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DrugHouse.Models
{
    public class Generic
    {
        public Generic()
        {
            this.Medicine = new List<Medicine>();
        }

        public int GenericID { get; set; }

        [Required, StringLength(50), Display(Name = "Generic")]
        public string GenericName { get; set; }

        //Nav-Permission
        public virtual ICollection<Medicine> Medicine { get; set; }
    }

    public class Provider
    {
        public Provider()
        {
            this.Medicine = new List<Medicine>();
        }

        public int ProviderID { get; set; }

        [Required, StringLength(50), Display(Name = "Provider")]
        public string ProviderName { get; set; }

        [Required, StringLength(50), Display(Name = "Contact Info")]
        public string ContactInfo { get; set; }

        //Nav-Permission
        public virtual ICollection<Medicine> Medicine { get; set; }
    }

    public class Medicine
    {
        public Medicine()
        {
            this.Bill = new List<Bill>();
        }

        public int MedicineID { get; set; }

        [Required, StringLength(50), Display(Name = "Medicine Name")]
        public string MedicineName { get; set; }

        [Required, Column(TypeName = "money"), DisplayFormat(DataFormatString = "{0:0.00}")]
        public decimal TreadPrice { get; set; }

        [Required, Column(TypeName = "money"), DisplayFormat(DataFormatString = "{0:0.00}")]
        public decimal MRP { get; set; }

        [Required, Column(TypeName = "date"), Display(Name = "Store Date"), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StoredDate { get; set; }

        [Required, Column(TypeName = "date"), Display(Name = "Expiration Date"), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Picture")]
        public string PicturePath { get; set; }

        [Required, Display(Name = "Quantity")]
        public int Quantity { get; set; }

        //FK
        [ForeignKey("Generic")]
        public int GenericID { get; set; }

        [ForeignKey("Provider")]
        public int ProviderID { get; set; }

        //Nav
        public virtual Generic Generic { get; set; }

        public virtual Provider Provider { get; set; }

        //Nav-Permission
        public virtual ICollection<Bill> Bill { get; set; }
    }

    public class Expense
    {
        public int ExpenseID { get; set; }

        public string User { get; set; }

        [Required, Column(TypeName = "money"), DisplayFormat(DataFormatString = "{0:0.00}")]
        public double Cost { get; set; }

        [Required]
        public String Details { get; set; }

        [Required, Column(TypeName = "date"), Display(Name = "Billing Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }
    }

    public class Bill
    {
        public int BillID { get; set; }
        public string User { get; set; }

        [Required, Column(TypeName = "money"), DisplayFormat(DataFormatString = "{0:0.00}")]
        public int Amount { get; set; }

        [Required, Column(TypeName = "date"), Display(Name = "Billing Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }

        public string MedicineID { get; set; }
    }

    public class DrugDbContext : DbContext
    {
        // if There are 2 context class we need to use this override method
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Error is comeing");
            }
        }

        public DrugDbContext(DbContextOptions<DrugDbContext> options) : base(options)
        {
        }

        public DbSet<Generic> Generic { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<Bill> Bill { get; set; }
    }
}