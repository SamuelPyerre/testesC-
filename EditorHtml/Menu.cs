using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");

            for(int i = 0; i <= 10; i++)
            {
                Console.Write("\n");
                Console.Write("|");
                for(int c = 0; c <= 30; c++)
                    Console.Write(" ");
                Console.Write("|");
            }
            Console.Write("\n");
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");

                
        }
    
        public static void WriteOptions()
        {
            Console.SetCursorPosition(4, 2);
            Console.Write("EDITOR HTML");

            Console.SetCursorPosition(4, 4);
            Console.Write("====================");

            Console.SetCursorPosition(4, 6);
            Console.Write("1- Criar");

            Console.SetCursorPosition(4, 7);
            Console.Write("2- Abrir");

            Console.SetCursorPosition(4, 8);
            Console.Write("0- Sair");

            Console.SetCursorPosition(4, 10);
            Console.Write("Selecione uma opção: ");


        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Console.WriteLine("Criar"); break;
                case 2: Console.WriteLine("Abrir"); break;
                case 0: {
                    Console.Clear();
                    Console.WriteLine("Volte sempre!");
                    System.Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}