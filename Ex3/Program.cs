using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] array = new int[10];
                Random random = new Random();

                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(-50, 50);
                }

                foreach (int a in array)
                {
                    System.Console.WriteLine("Элемент массива {0}", a);
                }
                System.Console.ReadKey();

                for (int i = 0; i < 4; i++)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }


                for (int i = 5; i < 9; i++)
                {
                    for (int j = i + 1; j < 10; j++)
                    {
                        if (array[i] < array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }

                Console.WriteLine();

                foreach (int a in array)
                {
                    System.Console.WriteLine("Элемент массива {0}", a);
                }
                System.Console.ReadKey();
            }
        }
    }
}
