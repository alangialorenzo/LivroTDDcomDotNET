using NUnit.Framework;

namespace Cap3
{
    [TestFixture]
    public class ConversorDeNumeroRomanoTest
    {
        static void Main()
        {
            ConversorDeNumeroRomanoTest teste = new ConversorDeNumeroRomanoTest();
            teste.DeveEntenderOSimboloI();
            teste.DeveEntenderOSimboloV();
            // O Código rodará sem erros no NUnit
        }

        [Test]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [Test]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }
    }
}
