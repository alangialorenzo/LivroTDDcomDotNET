/*
 * Necessário instalar o NUnit: http://www.nunit.org/ 
 * Em Manage NuGet Packages, pesquisar por: NUnit
 * Clique em Install - assim o instalará ao Projeto
 * Em References teremos agora: nunit.framework
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
            TestaMaiorEMenor teste = new TestaMaiorEMenor();
            teste.OrdemDecrescente();
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

            // Compile o Projeto
            // Abre o NUnit
            // Em Open Project, navegue até o diretório do Projeto
            // Vá em /bin/Debug e selecione o executável: Cap2.exe

            // Clique em Run no Unit, ocorrerá um Erro
            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }
    }
}
