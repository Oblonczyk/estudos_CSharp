using System;

namespace ConversaoImplicita_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //É possível tranformar um tipo com um numero de bytes menor em um maior mas...
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            //Só é possivel transformar um tipo maior em um menor, se fizermos como no exemplo a baixo:
            double a;
            int b;

            a = 5.1;
            b = (int)a;

            Console.WriteLine(b);

            //Se fizer o processo acima existem chances de que haja perda de dados

            int n = 5;
            int m = 2;

            double resultado = (double) n / m;

            Console.WriteLine(resultado);

        }
    }
}
