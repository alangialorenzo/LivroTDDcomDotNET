using System;

namespace Cap8
{
    public class Pedido
    {
        public string Cliente { get; private set; }
        public double ValorTotal { get; private set; }
        public int QuantidadeItens { get; private set; }

        public Pedido(string cliente, double valorTotal, int quantidadeItens)
        {
            this.Cliente = cliente;
            this.ValorTotal = valorTotal;
            this.QuantidadeItens = quantidadeItens;
        }
    }

    public class NotaFiscal
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public DateTime Data { get; private set; }

        public NotaFiscal(string cliente, double valor, DateTime data)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Data = data;
        }
    }

    public class SAP
    {
        public virtual void Envia(NotaFiscal nf)
        {
            // envia NF para o SAP
        }
    }

    public class NFDAO
    {
        public virtual void Persiste(NotaFiscal nf)
        {
            // persiste NF
        }
    }
}
