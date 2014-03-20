using System;

namespace Cap2
{
    public class TestaMaiorEMenor
    {
        static void Main()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Geladeira", (decimal)450.0));
            carrinho.Adiciona(new Produto("Liquidificador", (decimal)250.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", (decimal)70.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            // Ocorrerá um erro na execução
            Console.WriteLine("O menor produto " + algoritmo.Menor.Nome);
            Console.WriteLine("O maior produto " + algoritmo.Maior.Nome);

            Console.ReadKey();
        }
    }
}
