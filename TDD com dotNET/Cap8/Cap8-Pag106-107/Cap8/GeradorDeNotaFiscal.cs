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
        public IRelogio Relogio;
        public ITabela Tabela;

        // construtor sem Relógio para não quebrar o resto do sistema
        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes) : this(acoes, new RelogioDoSistema())
        {
            
        }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio)
        {
            this.Acoes = acoes;
            this.Relogio = relogio;
        }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio, ITabela tabela)
        {
            this.Acoes = acoes;
            this.Relogio = relogio;
            this.Tabela = tabela;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf =  new NotaFiscal(pedido.Cliente, pedido.ValorTotal * Tabela.ParaValor(pedido.ValorTotal), Relogio.Hoje());

            foreach(var acao in Acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }
    }
}
