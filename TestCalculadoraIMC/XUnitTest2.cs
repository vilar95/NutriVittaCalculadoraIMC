using NutriVittaIMC;
using Xunit;

namespace TestClassificacaoIMC
{
    public class XUnitTest2
    {
        [Fact]
        public void ClassificacaoIMC()
        {
            // Arrange - Prepara��o
            double imc = 29.16869227029655;
            var resultadoCorreto = "Sobrepeso.";

            //Act - A��o
            var resultadoIMC = CalculadoraIMC.ClassificacaoIMC(imc);

            //Assert - Verifica��o
            Assert.Equal(resultadoCorreto, resultadoIMC);
        }
        [Theory]
        [InlineData(31.46, "Grau Obesidade I.")]
        [InlineData(24.88, "Peso normal.")]
        [InlineData(17.16, "Abaixo do peso.")]
        public void ClassificacaoIMCLista(double imc, string resultadoIMC)
        {
            //Act - A��o
            var resultado = CalculadoraIMC.ClassificacaoIMC(imc);

            //Assert - Verifica��o
            Assert.Equal(resultadoIMC, resultado);
        }
    }
}