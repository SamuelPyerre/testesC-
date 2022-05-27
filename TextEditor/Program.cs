using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("Digite uma opção: 1- Abrir Arquivo 2- Criar Novo Arquivo 0- Sair");
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Abrir()
        {
            Console.WriteLine("Qual o caminho do arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite o texto: (ESC para sair!)");
            Console.WriteLine("------------------------");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("Arquivo salvando...");
            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Defina o caminho do arquivo: ");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.ReadLine();
            Console.WriteLine($"Arquivo salvo no diretório: {path} com sucesso!");
            Menu();
        }
    }
}