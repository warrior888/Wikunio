using System;

namespace Wikunio
{
    class Program
    {
        static void Main(string[] args) //zielona flaga w scratch
        {
            string wejscieZKonsoli = "";
                
            Console.WriteLine("Wikunio uczy sie programowania w c#!");
            Console.ForegroundColor = ConsoleColor.Red;

            while (true) //zawsze w scratch
            {
                Console.WriteLine("Podaj dowolne dane: ");
                wejscieZKonsoli = Console.ReadLine();

                if (wejscieZKonsoli.Contains("-04"))
                {
                    Console.WriteLine("Kwiecien");
                }

                if (wejscieZKonsoli.Contains("-02"))
                {
                    Console.WriteLine("Luty");
                }
            }
        }
    }
}
