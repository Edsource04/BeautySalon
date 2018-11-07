using Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace Repository.FluentAPI
{
    public sealed class QuotationMapping : EntityTypeConfiguration<Quotation>
    {
        public QuotationMapping()
        {
            HasKey(q => q.QuotationId);

            HasRequired(q => q.Client)
                .WithMany(c => c.Quotations)
                .HasForeignKey(q => q.ClientId)
                .WillCascadeOnDelete(false);

            HasRequired(q => q.Employee)
                .WithMany(w => w.Quotations)
                .HasForeignKey(q => q.WorkerId)
                .WillCascadeOnDelete(false);

            Property(p => p.Date).HasColumnType("Date");
        }
    }
}
