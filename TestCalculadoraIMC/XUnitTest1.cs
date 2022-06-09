using NutriVittaIMC;
using Xunit;

namespace TestCalculadoraIMC
{
    public class XUnitTest1
    {
        [Fact]
        public void IMC()
        {
            // Arrange - Prepara��o
            double altura = 1.87;
            double peso = 100;
            double resultadoCorreto = 28.6;

            //Act - A��o
            double resultado = CalculadoraIMC.IMC(altura, peso);
            

            //Assert - Verifica��o
            Assert.Equal(resultadoCorreto, resultado);
        }
        [Theory]
        [InlineData(1.87, 110, 31.46)]
        [InlineData(1.87, 87, 24.88)]
        [InlineData(1.87, 60, 17.16)]
        public void IMCLista(double altura, double peso, double resultadoCorreto)
        {
            //Act - A��o
            double resultado = CalculadoraIMC.IMC(altura, peso);


            //Assert - Verifica��o
            Assert.Equal(resultadoCorreto, resultado);

        }
    }
}