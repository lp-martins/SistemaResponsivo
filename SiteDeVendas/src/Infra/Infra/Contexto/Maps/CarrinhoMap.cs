using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto.Maps
{
    public class CarrinhoMap : IEntityTypeConfiguration<CarrinhoDeCompras>
    {
        public void Configure(EntityTypeBuilder<CarrinhoDeCompras> builder)
        {
            builder.ToTable("Carrinho_de_Compras");
            builder.HasKey(x => x.IdCompra);
            builder.Property(x => x.DescricaoDoProduto).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(x => x.QuantidadeComprada).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(x => x.ValorUnitario).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(x => x.ValorTotal).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(x => x.FormaDePagamento).IsRequired().HasMaxLength(25).HasColumnType("varchar(25)");
            builder.Property(x => x.DataDaCompra).IsRequired().HasColumnType("DATE");
        }
    }
}
