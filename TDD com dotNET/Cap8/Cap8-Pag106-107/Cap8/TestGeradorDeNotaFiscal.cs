using NUnit.Framework;
using Moq;
using System.Collections.Generic;

namespace Cap8
{
    [TestFixture]
    public class TestGeradorDeNotaFiscal
    {
        [Test]
        public void DeveConsultarATabelaParaCalcularValor()
        {

            // mockando uma tabela, que ainda não existe
            var tabela = new Mock<ITabela>();

            tabela.Setup(t => t.ParaValor(1000.0)).Returns(0.2);

            IList<IAcaoAposGerarNota> nenhumaAcao = new List<IAcaoAposGerarNota>();
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(nenhumaAcao, new RelogioDoSistema(), tabela.Object);
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            //garantindo que a tabela foi consultada
            tabela.Verify(t => t.ParaValor(1000.0));
            Assert.AreEqual(1000 * 0.2, nf.Valor, 0000.1);
        }
    }
}
