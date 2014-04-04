using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap9
{
    public enum MeioDePagamento
    {
        BOLETO,
        CARTAODECREDITO
    }

    public class Pagamento
    {
        public double Valor { get; private set; }
        public MeioDePagamento MeioDePagamento { get; private set; }

        public Pagamento(double boleto, MeioDePagamento meioDePagamento)
        {
            this.Valor = boleto;
            this.MeioDePagamento = meioDePagamento;
        }
    }
}
