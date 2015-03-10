using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaggeArray
{
    //锯齿形数组使用
    class Program
    {
        static void Main()
        {
            //声明一个锯齿形数组
            int[][] myArray=new int [2][];

            //第一行5个元素
            myArray[0] = new int[5] { 1, 3, 5, 7, 9 };

            //第二行4个元素
            myArray[1] = new int[4] { 2, 4, 6, 8 };

            //打印数组
            for (int i = 0; i < 2; i++)
            {
                Console.Write("第{0}个数组", i);

                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
