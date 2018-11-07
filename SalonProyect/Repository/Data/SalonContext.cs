using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.ModelConfiguration;
using Repository.FluentAPI;

namespace Repository.Data
{
    /// <summary>
    /// Context Class That has the configuration of the database for EntityFramework
    /// Usage: SalonContext = new SalonContext();
    /// </summary>
    public class SalonContext : DbContext
    {
        public SalonContext() : base("SalonContext") { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<ChargeOfAccount> ChargeOfAccounts { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SaleInvoice> SaleInvoices { get; set; }
        public DbSet<EmployeeUser> EmployeeUsers { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adding below EntityTypeConfiguration from System.Data.Entity.ModelConfiguration
            modelBuilder.Configurations.Add(new ClientMapping());
            modelBuilder.Configurations.Add(new WorkerMapping());
            modelBuilder.Configurations.Add(new ChargeOfAccountMapping());
            modelBuilder.Configurations.Add(new PurchaseInvoiceMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new SaleInvoiceMapping());
            modelBuilder.Configurations.Add(new QuotationMapping());
            modelBuilder.Configurations.Add(new ProductMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

        }
    }
}
