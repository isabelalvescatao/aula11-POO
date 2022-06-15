namespace Aula_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calcAnoNasc = new Calculadora();
            Usuario usuario = new Usuario();
            usuario.DadosDoUsuario();
            calcAnoNasc.calcularAnoNascimento();
            calcAnoNasc.status();
        }
    }
}