
namespace Cap6
{
    public class Item
    {
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public double ValorUnitario { get; private set; }

        public Item(string descricao, int quantidade, double valorUnitario)
        {
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.ValorUnitario = valorUnitario;
        }

        public double ValorTotal
        {
           get
           {
                return this.ValorUnitario * this.Quantidade;
           }
        }
    }
}
