using NUnit.Framework;

namespace Cap7
{
    [TestFixture]
    public class CalculadoraDeFuncionarioTest
    {
        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 4000.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.85, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 4500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4500.0 * 0.75, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaTestadoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.0, Cargo.TESTADOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.85, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaTestadoresComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 4500.0, Cargo.TESTADOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4500.0 * 0.75, salario, 0.00001);
        }

    }
}
