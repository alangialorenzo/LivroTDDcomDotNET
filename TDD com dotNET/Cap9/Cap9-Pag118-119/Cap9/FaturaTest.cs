using NUnit.Framework;

namespace Cap9
{
    [TestFixture]
    public class FaturaTest
    {
        [Test]
        public void ChecarSeFaturaPaga()
        {
            Fatura fatura = new Fatura("Cliente", 150.0);
            fatura.AdicionaPagamento(new Pagamento(150.0, MeioDePagamento.CARTAODECREDITO));

            Assert.IsTrue(fatura.Pago);
        }
    }
}
