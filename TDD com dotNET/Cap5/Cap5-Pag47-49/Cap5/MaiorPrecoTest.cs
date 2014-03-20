using NUnit.Framework;

namespace Cap5
{
    [TestFixture]
    public class MaiorPrecoTest
    {
        // NUnit roda sem erros!
        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            MaiorPreco algoritmo = new MaiorPreco();
            double valor = algoritmo.Encontra(carrinho);

            Assert.AreEqual(0.0, valor, 0.0001);
        }
    }
}
