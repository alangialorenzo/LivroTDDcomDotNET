using System.Collections.Generic;

namespace Cap9
{
    public class Fatura
    {
        public string Nome {get; private set;}
        public double Valor {get; private set;}
        public List<Pagamento> Pagamentos {get; private set;}

        public bool Pago { get; set; }

        public Fatura(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
        }
    }
}
