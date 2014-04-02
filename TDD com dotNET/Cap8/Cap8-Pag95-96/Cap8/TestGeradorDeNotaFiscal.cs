using NUnit.Framework;
using Moq;

namespace Cap8
{
    [TestFixture]
    public class TestGeradorDeNotaFiscal
    {

        [Test]
        public void DevePersistirNFGerada()
        {
            //criando o Mock
            var dao = new Mock<NFDAO>();
            var sap = new Mock<SAP>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            sap.Verify(t => t.Envia(nf));
        }
    }
}
