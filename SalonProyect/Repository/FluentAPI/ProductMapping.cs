using System.Data.Entity.ModelConfiguration;
using Domain.Models;

namespace Repository.FluentAPI
{
    public sealed class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            HasKey(p => p.Id);
            Property(p => p.EntryDate).HasColumnType("Date");

            HasRequired(p => p.ProductCategory)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.ProductCategoryId)
                .WillCascadeOnDelete(false);
        }
    }
}
