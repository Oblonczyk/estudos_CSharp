using System;

namespace Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if(x > 12 && x < 18)
            {
                Console.WriteLine("Boa tarde!");
            } else if(x > 5 && x < 12)
            {
                Console.WriteLine("Bom dia!");
            } else
            {
                Console.WriteLine("Boa noite!");
            }

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) 
            {
                Console.WriteLine("Número par.");
            } else
            {
                Console.WriteLine("Número ímpar.");
            }
        }
    }
}
