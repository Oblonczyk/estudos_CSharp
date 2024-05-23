using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCICIO 1:");

            string senha = "2002";
            string senhaCompara = Console.ReadLine();

            while (senha != senhaCompara)
            {
                Console.WriteLine("Senha Invalida");
            }
            Console.WriteLine("Acesso Permitido");

            Console.WriteLine("---------------------------");

            Console.WriteLine("EXERCICIO 2:");

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("EXERCICIO 3:");

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
