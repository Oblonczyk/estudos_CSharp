using System;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string palavrasJuntas = Console.ReadLine();
            string[] palavrasSeparadas = palavrasJuntas.Split(' ');

            string a = palavrasSeparadas[0];
            string b = palavrasSeparadas[1];
            string c = palavrasSeparadas[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
