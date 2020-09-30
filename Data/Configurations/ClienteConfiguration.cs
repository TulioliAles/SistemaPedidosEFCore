﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaPedidosEFCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPedidosEFCore.Data.Configurations
{
    class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.Telefone).HasColumnType("CHAR(11)");
            builder.Property(p => p.CEP).HasColumnType("CHAR(8)").IsRequired();
            builder.Property(p => p.Estado).HasColumnType("CHAR(7)").IsRequired();
            builder.Property(p => p.Nome).HasMaxLength(60).IsRequired();

            builder.HasIndex(i => i.Telefone).HasName("idx_cliente_telefone");
        }
    }
}
