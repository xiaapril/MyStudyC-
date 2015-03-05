using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace typeTran
{
    class Program
    {
        static void Main(string[] args)
        {
            //转换成功
            int intValue1, intValue2;
            long longValue1, longValue2;
            intValue1 = 123;
            longValue1 = 456;
            longValue2 = intValue1;//隐式转换
            intValue2 = (int)longValue1;//显示转换
            Console.WriteLine("long{0}={1}", intValue1, longValue2);
            Console.WriteLine("int{0}={1}", longValue1, intValue2);

            //转换失败
            long longValue3 = 2147483657L;
            int intValue3 = (int)longValue3;//int存放的最大值为2147483647，而把2147483657赋给int，所以溢出
            Console.WriteLine("int{0}={1}", longValue3, intValue3);
            Console.ReadLine();
        }
    }
}
