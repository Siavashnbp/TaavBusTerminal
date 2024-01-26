﻿using BusTerminal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTerminal.EnitityMap
{
    public class LocationEntityMap : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).UseIdentityColumn();
            builder.Property(_ => _.Province).HasMaxLength(50);
            builder.Property(_ => _.City).HasMaxLength(50);
            builder.Property(_ => _.Name).HasMaxLength(50);
        }
    }
}
