namespace Aula_11
{
    internal class Calculadora : Usuario
    {
        //variáveis exercício 6
        public int anoAtual = 2022;
        public int anoNascimento;
        
        public void calcularAnoNascimento()
        {
            anoNascimento = anoAtual - idadeDoUsuario;
        }

        public void status()
        {
            Console.WriteLine($"Olá {nomeDoUsuario}, você nasceu em {anoNascimento}");
        }
        

    }


}
