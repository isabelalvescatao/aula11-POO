namespace Aula_11
{
    internal class Calculadora : Usuario
    {
        //variáveis exercício 6
        public int anoAtual = 2022;
        public int anoNascimento;
        
        public void calcularAnoNascimento()
        {
            anoNascimento = anoAtual - IdadeDoUsuario;
        }

        public void status(string NomeDoUsuario, int anoNascimento)
        {
            Console.WriteLine($"Olá {NomeDoUsuario}, você nasceu em {anoNascimento}");
        }
        

    }


}
