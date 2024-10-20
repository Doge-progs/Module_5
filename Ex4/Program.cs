using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
            }

            int counter = 0;

            for (int i = 0; i < 20; i++)
            {
                if ((array[i] > 0) && (array[i] % 2 != 0) && (i % 2 != 0))
                {
                    counter++;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                System.Console.Write("{0, 3}", array[i]);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Количество положительных нечетных чисел стоящих на четных местах = {0}", counter);
            System.Console.ReadKey();
        }
    }
}
