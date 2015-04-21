using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bitOpt
{
    class Program
    {
        public static void Main(string[] args)
        {
            int varA = 10;//二进制为00001010
            int varB = 20;//二进制位00010100

            //"与"运算
            int andResult = varA & varB;
            Console.WriteLine("10 & 20 = {0}", andResult);

            //"或"运算
            int orResult = varA | varB;
            Console.WriteLine("10 | 20 = {0}", orResult);

            //"异或"运算
            int notorResult = varA ^ varB;
            Console.WriteLine("10 ^ 20 = {0}", notorResult);

            //"求补"运算
            Console.WriteLine("~ {0:x8}={1:x8}", varA, ~varB);

            //按位右移
            Console.WriteLine("{0:x8}>>3={1}", varA, varA >> 3);

            //按位左移
            Console.WriteLine("{0:x8}<<3={1}", varB, varB << 3);

            Console.ReadLine();
        }
    }
}
