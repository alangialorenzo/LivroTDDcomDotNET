using System;

namespace Cap8
{
    public class GeradorDeNotaFiscal
    {
        private NFDAO dao;

        public GeradorDeNotaFiscal(NFDAO dao)
        {
            this.dao = dao;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf =  new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, DateTime.Now);

            dao.Persiste(nf);

            return nf;
        }
    }
}
