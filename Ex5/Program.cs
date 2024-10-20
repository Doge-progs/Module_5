using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите размерность массива");
            int N = Convert.ToInt32(System.Console.ReadLine());

            int[,] array = new int[N, N];

            bool Flag = true;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Flag)
                    {
                        array[i, j] = 1;
                        Flag = false;
                    }
                    else
                    {
                        array[i, j] = 0;
                        Flag = true;
                    }

                    if ((i != 0 && j == 0) && (array[i - 1, j] == 1) && (N % 2 == 0))
                    {
                        array[i, j] = 0;
                        Flag = true;
                    }
                    
                    if ((i != 0 && j == 0) && (array[i - 1, j] == 0) && (N % 2 == 0))
                    {
                        array[i, j] = 1;
                        Flag = false;
                    }

                    System.Console.Write("{0, 2}", array[i, j]);
                }
                System.Console.WriteLine();
            }
            System.Console.ReadKey();
        }
    }
}
