using NUnit.Framework;
using Moq;
using System.Collections.Generic;

namespace Cap8
{
    [TestFixture]
    public class TestGeradorDeNotaFiscal
    {

        [Test]
        public void DeveInvocarAcoesPosteriores()
        {
            var acao1 = new Mock<IAcaoAposGerarNota>();
            var acao2 = new Mock<IAcaoAposGerarNota>();

            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>() { acao1.Object, acao2.Object };

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            acao1.Verify(a => a.Executa(nf));
            acao2.Verify(a => a.Executa(nf));
            
        }
    }
}
