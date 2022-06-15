namespace Aula_11
{
    internal class Usuario
    {
        protected string nomeDoUsuario;
        public string NomeDoUsuario
        {
            get { return nomeDoUsuario; }
            set { nomeDoUsuario = NomeDoUsuario; }
        }
        protected int idadeDoUsuario;
        public int IdadeDoUsuario
        {
            get { return idadeDoUsuario; }
            set { idadeDoUsuario = IdadeDoUsuario; }
        }
           
        public void DadosDoUsuario()
        {
            Console.WriteLine("Digite o seu nome: ");
            nomeDoUsuario = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            idadeDoUsuario = int.Parse(Console.ReadLine());
        }
    }
}
