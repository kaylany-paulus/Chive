using System;

namespace Chive
{
    class Program
    {
        static void Main(string[] args)
        {
            string tongueTwister;
            int numTongueTwister;

            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("\nBem vindo!");
            Console.ResetColor();
            Console.WriteLine("\n\nPoderia por favor digitar um bom trava lingua com (r),em seguida vou tentar repetir kkkk");
            Console.WriteLine("\nNesse caso vamos ver quem é o melhor!");
            tongueTwister= Console.ReadLine();
            bool tongueLockCheck = Int32.TryParse(tongueTwister, out numTongueTwister );
            if (tongueLockCheck)
            {
                Console.Clear();
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine($"\nESSA OPÇÃO ({numTongueTwister}) NÃO É VÁLIDA.");
                Console.ResetColor();
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("\n\nObrigada pelo acesso!");
                Console.ResetColor();
                Environment.Exit(-1);

            }
            string newTongueLock=tongueTwister
                .Replace("r","l")
                .Replace("R", "L")
                .Replace("rr","ll")
                .Replace("RR","LL");


            Console.Clear();  
            Console.WriteLine("\nMinha vez de repetir agora...");
            Console.ReadKey();
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.WriteLine($"\n\n{newTongueLock}");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("\nPelo visto eu não sou tão boa em trava linguas quanto você.");
            Console.WriteLine("\nNesse caso você ganhou essa competição.");
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.WriteLine("PARABÉNS!");
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\n\nObrigada pelo acesso!");
            Console.ResetColor();
            {
                
            }
        }
    }
}
