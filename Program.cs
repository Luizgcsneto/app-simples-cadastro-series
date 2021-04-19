using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Series ao seu dispor!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar Séries!");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série!");
            Console.WriteLine("4 - Excluir série:");
            Console.WriteLine("5 - Visualizar série!");
            Console.WriteLine("C - Limpar tela:");
            Console.WriteLine("X - Sair!");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
