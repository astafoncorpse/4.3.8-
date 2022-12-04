using System;

namespace ConsoleApp4._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввидите своё имя");
            var name = Console.ReadLine();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + "");
            }
                
            Console.ReadKey();
        }
    }
}
