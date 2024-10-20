using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(System.Console.ReadLine());

            int[,] array = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    System.Console.WriteLine("Введите значение");
                    array[i, j] = Convert.ToInt32(System.Console.ReadLine());
                }
            }



            int sum_row = 0;
            bool row = true;

            for (int i = 0; i < N; i++)
            {
                sum_row += array[0, i];
            }

            int sum_coloumn = 0;
            bool coloumn = true;

            for (int i = 0; i < N; i++)
            {
                sum_coloumn += array[i, 0];
            }

            int sum_diagonale = 0;
            bool diagonale = true;

            for (int i = 0; i < N; i++)
            {
                sum_diagonale += array[i, i];
            }



            #region Rows
            for (int i = 0; i < N; i++)
            {
                int local_row = 0;
                for (int j = 0; j < N; j++)
                {
                    local_row += array[i, j];
                }

                if (local_row != sum_row)
                {
                    row = false;
                }
            }
            #endregion

            #region Coloumns
            for (int i = 0; i < N; i++)
            {
                int local_coloumn = 0;
                for (int j = 0; j < N; j++)
                {
                    local_coloumn += array[j, i];
                }

                if (local_coloumn != sum_coloumn)
                {
                    coloumn = false;
                }
            }
            #endregion

            #region Diagonale
            int local_diagonale = 0;
            int left = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                local_diagonale += array[i, left];
                left++;
            }

            if (local_diagonale != sum_diagonale)
            {
                diagonale = false;
            }
            #endregion

            if (row && coloumn && diagonale)
            {
                System.Console.WriteLine("Матрица магическая");
                System.Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine("Матрица не является магической");
                System.Console.ReadKey();
            }
        }
    }
}
