
namespace Cap2
{
    public class Produto
    {
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }

        public Produto(string Nome, decimal Valor)
        {
            this.Nome = Nome;
            this.Valor = Valor;
        }
    }
}
