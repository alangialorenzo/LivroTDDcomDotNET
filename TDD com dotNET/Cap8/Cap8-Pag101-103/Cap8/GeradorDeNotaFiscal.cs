using System;
using System.Collections.Generic;

namespace Cap8
{
    public interface IAcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);
    }


    public class GeradorDeNotaFiscal
    {
        public IList<IAcaoAposGerarNota> Acoes;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            this.Acoes = acoes;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf =  new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, DateTime.Now);

            foreach(var acao in Acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }
    }
}
