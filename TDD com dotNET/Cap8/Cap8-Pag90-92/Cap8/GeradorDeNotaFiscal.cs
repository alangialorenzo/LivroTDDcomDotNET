using System;

namespace Cap8
{
    public class GeradorDeNotaFiscal
    {
        public NotaFiscal Gera(Pedido pedido)
        {
            return new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, DateTime.Now);
        }
    }
}
