using Xunit;

namespace TestClassificacaoIMC
{
    public class XUnitTest2
    {
        [Fact]
        public void ClassificacaoIMC()
        {
            // Arrange - Preparação
            double altura = 1.87;
            double peso = 100;
            double resultadoCorreto = 26.7379679144385;

            //Act - Ação
            double imc = peso / (altura + altura);


            //Assert - Verificação
            Assert.Equal(resultadoCorreto, imc);
        }
        [Theory]
        [InlineData(26.737967914438)]
        [InlineData(23.262032085561497)]
        [InlineData(16.0427807486631)]
        public void ClassificacaoIMCLista(double imc, string resultadoIMC)
        {
            //Act - Ação
            var resultadoCorreto = ClassificacaoIMC.


            //Assert - Verificação
            Assert.Equal(resultadoIMC, resultadoCorreto);
        }
}