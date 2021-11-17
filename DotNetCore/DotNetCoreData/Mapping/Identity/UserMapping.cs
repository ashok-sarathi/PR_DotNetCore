using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetCoreEntity.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCoreData.Mapping.Identity
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public const int FirstNameMaxLength = 100;
        public const int LastNameMaxLength = 100;
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(FirstNameMaxLength);

            builder
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(LastNameMaxLength);

            builder
                .Property(p => p.Email)
                .IsRequired();

            builder
                .Property(p => p.Password)
                .IsRequired();
        }
    }
}
