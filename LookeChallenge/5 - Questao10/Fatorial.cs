using System;
using System.Collections.Generic;
using System.Text;

namespace LookeChallenge._5___Questao10
{
    public class Fatorial
    {
        public static void FatorialTeste()
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            double total = 1;
            double denominador = 1;
            for (int i = 1; i <= n; i++)
            {
                denominador *= i;
                total += 1.0 / denominador;
            }
            Console.WriteLine(total);
        }
    }
}
