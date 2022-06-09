using Xunit;

namespace TestClassificacaoIMC
{
    public class XUnitTest2
    {
        [Fact]
        public void ClassificacaoIMC()
        {
            // Arrange - Prepara��o
            double altura = 1.87;
            double peso = 100;
            double resultadoCorreto = 26.7379679144385;

            //Act - A��o
            double imc = peso / (altura + altura);


            //Assert - Verifica��o
            Assert.Equal(resultadoCorreto, imc);
        }
        [Theory]
        [InlineData(26.737967914438)]
        [InlineData(23.262032085561497)]
        [InlineData(16.0427807486631)]
        public void ClassificacaoIMCLista(double imc, string resultadoIMC)
        {
            //Act - A��o
            var resultadoCorreto = ClassificacaoIMC.


            //Assert - Verifica��o
            Assert.Equal(resultadoIMC, resultadoCorreto);
        }
}