using System;

namespace Cap8
{
    public class GeradorDeNotaFiscal
    {
        private NFDAO dao;
        private SAP sap;

        public GeradorDeNotaFiscal(NFDAO dao, SAP sap)
        {
            this.dao = dao;
            this.sap = sap;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf =  new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, DateTime.Now);

            dao.Persiste(nf);
            sap.Envia(nf);

            return nf;
        }
    }
}
