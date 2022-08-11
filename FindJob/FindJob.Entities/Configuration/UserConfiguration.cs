using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FindJob.Entities.Concrete;

namespace FindJob.Entities.Configuration
{
    class UserConfiguration:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property(ns => ns.Username).IsRequired();
            builder.Property(c => c.Password).IsRequired();
        }
    }
}
