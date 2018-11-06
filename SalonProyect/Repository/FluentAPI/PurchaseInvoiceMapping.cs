using System;
using System.Data.Entity.ModelConfiguration;
using Domain.Models;

namespace Repository.FluentAPI
{
    public sealed class PurchaseInvoiceMapping : EntityTypeConfiguration<PurchaseInvoice>
    {
        public PurchaseInvoiceMapping()
        {
            HasKey(p => p.InvoiceId);

            Property(p => p.PurchaseDate).HasColumnType("Date");

            Ignore(p => p.PaymentTypeToString);
            Ignore(p => p.PaymentMethodToString);

            HasRequired(c => c.Client)
                .WithMany(p => p.PurchaseInvoices)
                .HasForeignKey(p => p.ClientId)
                .WillCascadeOnDelete(false);

            HasRequired(w => w.WorkerEmployee)
                .WithMany(p => p.PurchaseInvoices)
                .HasForeignKey(w => w.EmployeeId)
                .WillCascadeOnDelete(false);
        }
    }
}
