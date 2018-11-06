using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Domain.Models;

namespace Repository.FluentAPI
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(u => u.Id);
            Ignore(u => u.RollName);
            Property(u => u.Username).IsRequired();
            Property(u => u.Password).IsRequired();

            HasOptional(o => o.EmployeeUser)
                .WithOptionalPrincipal(p => p.User);
        }
    }
}
