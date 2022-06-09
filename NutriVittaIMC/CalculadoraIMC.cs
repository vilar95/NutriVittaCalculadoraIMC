namespace NutriVittaIMC
{
    public static class CalculadoraIMC
    {
        public static double IMC(double altura, double peso)
        {
            return Math.Round(peso / Math.Pow(altura, 2), 2);
                  

        }
        public static string ClassificacaoIMC(double imc)
        {

            switch (imc)
            {
                case double when imc > 0 && imc < 18.5:
                    return "Abaixo do peso.";

                case double when imc >= 18.5 && imc < 25:
                    return "Peso normal.";

                case double when imc >= 25 && imc < 30:
                    return "Sobrepeso.";

                case double when imc >= 30 && imc < 35:
                    return "Grau Obesidade I.";

                case double when imc >= 35 && imc < 40:
                    return "Grau Obesidade II.";

                case double when imc >= 40:
                    return "Grau Obesidade III.";

                default:
                    return "IMC inválido";
            }
        }
    }
}