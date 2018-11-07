
using System.Data.Entity.ModelConfiguration;
using Domain.Models;

namespace Repository.FluentAPI
{
    public sealed class QuotationLineMapping : EntityTypeConfiguration<QuotationLine>
    {
        public QuotationLineMapping()
        {
            HasKey(q => q.QuotationLineId);
            Property(q => q.EntryDate).HasColumnType("Date");

            HasRequired(q => q.Quotation)
                .WithMany(q => q.QuotationLines)
                .HasForeignKey(q => q.QuotationId)
                .WillCascadeOnDelete(false);
        }
    }
}
