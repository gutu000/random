using System;

namespace he
{
    class program
    {
        static void Main(string[]args)
        {
            Hundra();
        }
        static void Hundra()
        {
            Console.Write("Gissa nummer: ");
            int x = int.Parse(Console.ReadLine());
            Random nmr = new Random();
            int resultat = nmr.Next();
            Console.WriteLine("Talet är: " + nmr.Next(1, 100));

            if (x == resultat)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Du gissade rätt");
                Console.ResetColor();
                Console.WriteLine();             
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Du gissade fel");
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine("1 om du vill försöka igen");
            Console.WriteLine("2 om du vill avsluta");
            string val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    Hundra();
                    break;
                case "2":
                    break;
                    
            }
        }
    }
}