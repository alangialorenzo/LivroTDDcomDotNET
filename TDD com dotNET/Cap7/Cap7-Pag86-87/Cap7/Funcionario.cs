
namespace Cap7
{
    public class Cargo
    {
        public static Cargo DESENVOLVEDOR
        {
            get
            {
                return new Cargo(new DezOuVintePorCento());
            }
        }

        public static Cargo DBA
        {
            get
            {
                return new Cargo(new QuinzeOuVinteCincoPorCento());
            }
        }
        public static Cargo TESTADOR
        {
            get
            {
                return new Cargo(new QuinzeOuVinteCincoPorCento());
            }
        }

        public RegraDeCalculo Regra { get; private set; }
        private Cargo(RegraDeCalculo regra)
        {
            this.Regra = regra;
        }
    }

    public class Funcionario
    {
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public Cargo Cargo { get; private set; }

        public Funcionario(string Nome, double Salario, Cargo Cargo)
        {
            this.Nome = Nome;
            this.Salario = Salario;
            this.Cargo = Cargo;
        }
    }
}
