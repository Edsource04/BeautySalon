using System.Data.Entity.ModelConfiguration;
using Domain.Models;

namespace Repository.FluentAPI
{
    public sealed class ChargeOfAccountMapping : EntityTypeConfiguration<ChargeOfAccount>
    {
        public ChargeOfAccountMapping()
        {
            HasKey(c => c.Id);

            HasRequired(c => c.Client)
                .WithMany(charg => charg.ChargeOfAccounts)
                .HasForeignKey(f => f.ClientId)
                .WillCascadeOnDelete(false);
        }
    }
}
