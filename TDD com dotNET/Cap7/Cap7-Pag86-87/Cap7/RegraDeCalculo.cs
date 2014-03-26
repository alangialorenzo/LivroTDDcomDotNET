
namespace Cap7
{
    public abstract class RegraDeCalculo
    {

        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Salario > Limite())
            {
                return funcionario.Salario * PorcentagemAcimdaDoLimite();
            }
            return funcionario.Salario * PorcentagemBase();
        }

        protected abstract int Limite();

        protected abstract double PorcentagemAcimdaDoLimite();

        protected abstract double PorcentagemBase();
    }


    public class DezOuVintePorCento : RegraDeCalculo
    {
        protected override double PorcentagemBase()
        {
            return 0.9;
        }

        protected override double PorcentagemAcimdaDoLimite()
        {
            return 0.8;
        }

        protected override int Limite()
        {
            return 3000;
        }
    }

    public class QuinzeOuVinteCincoPorCento : RegraDeCalculo
    {
        protected override double PorcentagemBase()
        {
            return 0.85;
        }

        protected override double PorcentagemAcimdaDoLimite()
        {
            return 0.75;
        }

        protected override int Limite()
        {
            return 2500;
        }
    }
}
