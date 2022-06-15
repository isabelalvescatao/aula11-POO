namespace Aula_11
{
    internal class Usuario
    {
        private string nomeDoUsuario;
        public string NomeDoUsuario
        {
            get { return nomeDoUsuario; }
            set { nomeDoUsuario = value; }
        }
        private int idadeDoUsuario;
        public int IdadeDoUsuario
        {
            get { return idadeDoUsuario; }
            set { idadeDoUsuario = value; }
        }
           
        public void DadosDoUsuario()
        {
            Console.WriteLine("Digite o seu nome: ");
            nomeDoUsuario = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            idadeDoUsuario = int.Parse(Console.ReadLine());
        }
    }

//    class TesteUsuario
//    { 
//        static void Main(string[] args)
//    {
//        Usuario user01 = new Usuario();
//        user01.DadosDoUsuario();
//        Console.WriteLine(user01.NomeDoUsuario);
//        Console.WriteLine(user01.IdadeDoUsuario);

//    }
//}
}
