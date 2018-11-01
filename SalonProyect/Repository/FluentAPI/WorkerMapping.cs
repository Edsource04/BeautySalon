using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace Repository.FluentAPI
{
    public sealed class WorkerMapping : EntityTypeConfiguration<Worker>
    {
        public WorkerMapping()
        {
            HasKey(w => w.WorkerId);
            Property(c => c.Birthday).HasColumnType("Date");
            Property(p => p.InsertedDate).HasColumnType("DateTime");
            Property(p => p.ModifiedDate).HasColumnType("DateTime");
        }
    }
}
