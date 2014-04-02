using NUnit.Framework;

namespace Cap8
{
    [TestFixture]
    public class TestGeradorDeNotaFiscal
    {

        [Test]
        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal();
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(1000 * 0.94, nf.Valor, 0.0001);
        }
    }
}
