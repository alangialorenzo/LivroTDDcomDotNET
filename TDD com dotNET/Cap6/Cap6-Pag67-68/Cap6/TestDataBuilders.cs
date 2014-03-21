using NUnit.Framework;

namespace Cap6
{
    [TestFixture]
    public class TestDataBuilders
    {
        private CarrinhoDeCompras carrinho;

        [SetUp]
        public void Inicializa()
        {
            carrinho = new CarrinhoDeComprasBuilder().Itens().Cria();
        }

        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            Assert.AreEqual(0.0, carrinho.MaiorValor(), 0.00001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            carrinho = new CarrinhoDeComprasBuilder().Itens("Geladeira", 1, 900.0).Cria();

            Assert.AreEqual(900.0, carrinho.MaiorValor(), 0.0001);
        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            carrinho = new CarrinhoDeComprasBuilder().Itens("Geladeira", 1, 900.0)
                                            .Itens("Fogão", 2, 1500.0)
                                            .Itens("Máquina de Lavar", 1, 750.0).Cria();

            Assert.AreEqual(3000.0, carrinho.MaiorValor(), 0.0001);
        }
    }
}
