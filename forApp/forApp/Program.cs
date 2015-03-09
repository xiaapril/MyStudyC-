using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("打印九九乘法表");

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
