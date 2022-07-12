using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{
    internal class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Desenho();
            EscreverOpcoes();

            var options = byte.Parse(Console.ReadLine());
            MenuOpcoes(options);    
        }

        public static void Desenho()
        {
            Console.Write("+");
            for(int i = 0; i <= 40; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for(int j = 0; j <= 10; j++)
            {
                Console.Write("|");
                for (int i = 0; i <= 40; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 40; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void EscreverOpcoes()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("----------- Editor HTML -----------");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===================================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opcao abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,11);
            Console.Write("Opcao:");

        }

        public static void MenuOpcoes(byte options)
        {
            switch(options)
            {
                case 0: System.Environment.Exit(0);break;
                case 1: Editor.Show();break;
                case 2: Console.WriteLine("Editor"); break;
                default: Show(); break;

            }
        }

     
    }
}
