﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(e => e.ClientId).HasName("PK__Clients__E67E1A24109C471A");

            builder.Property(e => e.Address).IsUnicode(false);
            builder.Property(e => e.DocumentNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            builder.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.HasOne(d => d.DocumentType).WithMany(p => p.Clients)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Clients__Documen__5EBF139D");
        }
    }
}
