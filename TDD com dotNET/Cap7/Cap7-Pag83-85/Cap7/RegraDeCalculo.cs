
namespace Cap7
{
    public interface IRegraDeCalculo
    {
        double Calcula(Funcionario f);
    }

    public class DezOuVintePorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Salario > 3000)
            {
                return funcionario.Salario * 0.8;
            }
            return funcionario.Salario * 0.9;
        }
    }

    public class QuinzeOuVinteCincoPorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Salario < 2500)
            {
                return funcionario.Salario * 0.85;
            }
            return funcionario.Salario * 0.75;
        }
    }
}
