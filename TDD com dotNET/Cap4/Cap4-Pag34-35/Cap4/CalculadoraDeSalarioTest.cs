using NUnit.Framework;

namespace Cap4
{
    [TestFixture]
    public class CalculadoraDeSalarioTest
    {
        static void Main()
        {
            // NUnit rodará sem erros!
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Maurício", 1500.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }
    }
}
