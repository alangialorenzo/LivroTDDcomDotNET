using System.Collections.Generic;

namespace Cap2
{
    public class CarrinhoDeCompras
    {
        private IList<Produto> _produtos;

        public CarrinhoDeCompras()
        {
            _produtos = new List<Produto>();
        }

        public IEnumerable<Produto> Produtos
        {
            get { return _produtos; }
        }

        public void Adiciona(Produto produto)
        {
            _produtos.Add(produto);
        }
    }
}
