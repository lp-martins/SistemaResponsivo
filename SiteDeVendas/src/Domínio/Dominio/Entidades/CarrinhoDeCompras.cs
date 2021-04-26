using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class CarrinhoDeCompras
    {
        public CarrinhoDeCompras(int idCompra, string descricaoDoProduto, int quantidadeComprada, decimal valorUnitario, decimal valorTotal, string formaDePagamento, DateTime dataDaCompra)
        {
            IdCompra = idCompra;
            DescricaoDoProduto = descricaoDoProduto;
            QuantidadeComprada = quantidadeComprada;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
            FormaDePagamento = formaDePagamento;
            DataDaCompra = dataDaCompra;
        }

        public int IdCompra { get; set; }
        public string DescricaoDoProduto { get; set; }
        public int QuantidadeComprada { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public string FormaDePagamento { get; set; }
        public DateTime DataDaCompra { get; set; }
    }
}
