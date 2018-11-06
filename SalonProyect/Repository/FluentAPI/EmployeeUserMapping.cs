using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Domain.Models;

namespace Repository.FluentAPI
{
    class EmployeeUserMapping : EntityTypeConfiguration<EmployeeUser>
    {
        public EmployeeUserMapping()
        {
            HasKey(e => e.Id);

            Property(p => p.AssigmentDate).HasColumnType("Date");
            Property(p => p.DeAssigmentDate).HasColumnType("Date");
            Property(p => p.InsertedDate).HasColumnType("datetime");
            Property(p => p.ModifiedDate).HasColumnType("datetime");

        }
    }
}
