using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrixMultiply
{
    class Program
    {
        static void Main()
        {
            //声明一个2行3列矩阵
            int[,] matrixA = new int[2, 3];

            //声明一个3行4列矩阵
            int[,] matrixB = new int[3, 4] { { 4, 2, 1, 7 }, { 3, 6, 1, 0 }, { 5, 3, 2, 4 } };

            //声明一个2行4列矩阵
            int[,] matrixC = new int[2, 4];

            //初始化矩阵A
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixA[i, j] = (i + 2) * (j + 2) + 1;
                }
            }

            //计算矩阵A和B的乘积
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrixC[i, j] = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            Console.WriteLine("\n*******矩阵A*******");
            outputMatrix(matrixA, 2, 3);

            Console.WriteLine("\n*******矩阵B*******");
            outputMatrix(matrixB, 3, 4);

            Console.WriteLine("\n*******矩阵C*******");
            outputMatrix(matrixC, 2, 4);

            Console.ReadLine();
        }

        private static void outputMatrix(int[,] matrixX, int rowCount, int columCount)
        {
            //如果行列数错误，不打印矩阵
            if (matrixX.Length != rowCount * columCount)
            {
                Console.WriteLine("行列数错误！");
                return;
            }

            //打印矩阵
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columCount; j++)
                {
                    Console.Write(matrixX[i, j] + "\t");
                }

                //换行
                Console.WriteLine();
            }
        }
    }
}
