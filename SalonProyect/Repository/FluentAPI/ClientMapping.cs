using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Domain.Models;

namespace Repository.FluentAPI
{
    public sealed class ClientMapping : EntityTypeConfiguration<Client>
    {
        public ClientMapping()
        {
            HasKey(c => c.IdClient);
            Property(c => c.Birthday).HasColumnType("Date");
            Property(p => p.InsertedDate).HasColumnType("DateTime");
            Property(p => p.ModifiedDate).HasColumnType("DateTime");
        }
    }
}
