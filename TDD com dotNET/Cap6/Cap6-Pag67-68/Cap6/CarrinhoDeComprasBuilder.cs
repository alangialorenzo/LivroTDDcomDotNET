
namespace Cap6
{
    public class CarrinhoDeComprasBuilder
    {
        public CarrinhoDeCompras carrinho;

        public CarrinhoDeComprasBuilder()
        {
            this.carrinho = new CarrinhoDeCompras();
        }

        public CarrinhoDeComprasBuilder Itens()
        {
            return this;
        }

        public CarrinhoDeComprasBuilder Itens(string descricao, int quantidade, double valorUnitario)
        {
            carrinho.Adiciona(new Item(descricao, quantidade, valorUnitario));
            return this;
        }
        

        public CarrinhoDeCompras Cria()
        {
            return carrinho;
        }
    }
}
