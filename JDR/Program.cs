using System;
using System.Media;

namespace JDR
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Game g = new Game();
                Console.WriteLine("\n \n Une nouvelle partie ? (o/n)");
            } while (Console.ReadLine() == "o");
        }
    }

}
