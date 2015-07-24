/* 
 * RECEBE UM NUMERO N MAIOR QUE ZERO E RETORNA O PRÓXIMO 10 NÚMEROS PRIMOS.
 * 
 */

using System;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number..: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                int m = n + 1;
                int cont = 0;
                string numbers = string.Empty;

                while (cont < 10)
                {
                    bool result = verificaPrimo(m);
                    if (result == true)
                    {
                        numbers = numbers + " " + Convert.ToString(m) + " ";
                        cont++;
                    }
                    m = m + 1;
                }
                Console.WriteLine("10 next prime numbers: {0}", numbers);
                Console.Read();
            }
        }

        static bool verificaPrimo(int num)
        {
            bool result = true;
            for ( int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;            
            }
            return result;            
        }
    }
}