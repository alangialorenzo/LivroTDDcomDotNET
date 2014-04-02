using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using System;

namespace Cap8
{
    [TestFixture]
    public class TestGeradorDeNotaFiscal
    {

        [Test]
        public void DeveInvocarAcoesPosterioresERelogioDoSistemaTambem()
        {
            var acao1 = new Mock<IAcaoAposGerarNota>();
            var acao2 = new Mock<IAcaoAposGerarNota>();

            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>() { acao1.Object, acao2.Object };

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes,new RelogioDoSistema());
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            // Testando que nunca será gerado NF no Sábado ou Domingo
            Assert.AreNotEqual(nf.Data.DayOfWeek, DayOfWeek.Saturday);
            Assert.AreNotEqual(nf.Data.DayOfWeek, DayOfWeek.Sunday);

            // Testando dia atual - Testado Numa Segunda(Monday)
            //Assert.AreEqual(nf.Data.DayOfWeek, DayOfWeek.Monday);

            acao1.Verify(a => a.Executa(nf));
            acao2.Verify(a => a.Executa(nf));
        }
    }
}
