using System;


namespace Tron
{
    class Program
    {
        static void Main(string[] args)
        {
            string hhh = "hel";

            Console.WriteLine(55);
            Console.WriteLine($"Привет{hhh}");
            Console.WriteLine("Привет"+hhh);

            Console.ReadKey(); 
        }

        static int good(int mys)
        {
            int bots = mys * 2;
            return bots;
        }
    }