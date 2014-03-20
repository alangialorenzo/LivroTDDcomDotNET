/*
 * Lembre-se sempre de compilar o projeto antes de executá-lo no NUnit 
*/
using System;
using NUnit.Framework;

namespace Cap2
{
    [TestFixture]
    public class TestaMaiorEMenor
    {
        static void Main()
        {
            // Ao ser executado no NUnit, todos os testes serão executados sem erros
        }
        
        [Test]
        public void OrdemDecrescente()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Geladeira", (decimal)450.0));
            carrinho.Adiciona(new Produto("Liquidificador", (decimal)250.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", (decimal)70.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }

        [Test]
        public void OrdemCrescente()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Jogo de pratos", (decimal)70.0));
            carrinho.Adiciona(new Produto("Liquidificador", (decimal)250.0));
            carrinho.Adiciona(new Produto("Geladeira", (decimal)450.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }

        [Test]
        public void OrdemVariada()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Liquidificador", (decimal)250.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", (decimal)70.0));
            carrinho.Adiciona(new Produto("Geladeira", (decimal)450.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }

        [Test]
        public void ApenasUmProduto()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Geladeira", (decimal)450.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Geladeira", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }  
    }
}
