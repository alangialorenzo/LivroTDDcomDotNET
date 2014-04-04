using System.Collections.Generic;

namespace Cap9
{
    public class ProcessadorDeBoletos
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            double valorTotal = 0;

            foreach (var boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);

                fatura.Pagamentos.Add(pagamento);

                valorTotal += boleto.Valor;
            }

            if (valorTotal >= fatura.Valor)
            {
                fatura.Pago = true;
            }
        }
    }
}
