namespace Aula_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calcAnoNasc = new Calculadora();
            calcAnoNasc.DadosDoUsuario();
            calcAnoNasc.calcularAnoNascimento();
            calcAnoNasc.status(calcAnoNasc.NomeDoUsuario, calcAnoNasc.anoNascimento);
        }
    }
}