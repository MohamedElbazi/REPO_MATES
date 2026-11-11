
using System;

namespace MatesLib1
{
    public static class Mates
    {
        public static void TaulaMultiplicar(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        public static int SumaFins(int n)
        {
            int suma = 0;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }

            return suma;
        }
    }
}
