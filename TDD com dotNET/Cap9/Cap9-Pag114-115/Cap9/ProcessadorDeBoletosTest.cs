using System.Collections.Generic;
using NUnit.Framework;

namespace Cap9
{
    [TestFixture]
    public class ProcessadorDeBoletosTest
    {
        [Test]
        public void DeveMarcarFaturaComoPagaCasoBoletoUnicoPagueTudo()
        {
            ProcessadorDeBoletos processador = new ProcessadorDeBoletos();

            Fatura fatura = new Fatura("Cliente", 150.0);
            Boleto b1 = new Boleto(150.0);
            IList<Boleto> boletos = new List<Boleto>() { b1 };

            processador.Processa(boletos, fatura);

            Assert.IsTrue(fatura.Pago);
        }
    }
}
