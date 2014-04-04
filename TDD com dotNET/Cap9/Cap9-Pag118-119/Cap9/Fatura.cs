using System.Collections.Generic;

namespace Cap9
{
    public class Fatura
    {
        public string Nome {get; private set;}
        public double Valor {get; private set;}
        public List<Pagamento> Pagamentos {get; private set;}

        public bool Pago { get; private set; }

        public Fatura(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            this.Pagamentos.Add(pagamento);

            double valorTotal = 0;

            foreach (var p in Pagamentos)
            {
                valorTotal += p.Valor;
            }

            if(valorTotal >= this.Valor)
            {
                this.Pago = true;
            }
        }
    }
}
