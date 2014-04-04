using System.Collections.Generic;

namespace Cap9
{
    public class ProcessadorDeBoletos
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            Boleto boleto = boletos[0];

            Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
            
            fatura.Pagamentos.Add(pagamento);
        }
    }
}
