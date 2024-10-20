using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
            }

            int array_max = array[0];
            int array_min = array[0];

            foreach (int a in array)
            {
                if (a > array_max)
                {
                    array_max = a;
                }
                if (a < array_min)
                {
                    array_min = a;
                }
            }

            for (int i = 0; i < 15; i++)
            {
                Console.Write("{0, 3}", array[i]);

            }
            Console.WriteLine();
            Console.WriteLine("Максимальное значение {0}", array_max);
            Console.WriteLine("Минимальное значение {0}", array_min);
            Console.ReadKey();
        }
    }
}
