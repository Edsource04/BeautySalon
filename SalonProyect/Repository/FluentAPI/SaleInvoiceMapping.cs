using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Domain.Models;

namespace Repository.FluentAPI
{
    public sealed class SaleInvoiceMapping : EntityTypeConfiguration<SaleInvoice>
    {
        public SaleInvoiceMapping()
        {
            HasKey(s => s.SaleInvoiceId);
            Property(s => s.SalesDate).HasColumnType("Date");
            HasRequired(s => s.Client)
                .WithMany(s => s.SaleInvoices)
                .HasForeignKey(s => s.ClientId)
                .WillCascadeOnDelete(false);

            HasRequired(s => s.Worker)
                .WithMany(s => s.SaleInvoices)
                .HasForeignKey(s => s.WorkerId)
                .WillCascadeOnDelete(false);

            HasOptional(s => s.PurchaseInvoice)
                .WithOptionalPrincipal(s => s.Sale);
        }
    }
}
