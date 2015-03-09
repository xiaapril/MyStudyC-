using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ifApp
{
    class Program
    {
        static int Main(string[] args)
        {
            //如果命令行参数小于一个，则显示程序正确用法，退出程序
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: ifApp char");
                Console.ReadLine();
                return 1;
            }

            //获取第一个命令行参数的首字母
            //把该字母赋给chLetter
            char chLetter = args[0][0];

            //如果字母大于等于字符‘A’
            if (chLetter >= 'A')
            {
                //且字母小于等于字符‘Z’，则为大写字母
                if (chLetter <= 'Z')
                { 
                    Console.WriteLine("{0} 是大写字母",chLetter);
                    Console.ReadLine();
                    return 0;
                }
            
            }

            //小写字母判断
            if (chLetter >= 'a' && chLetter <= 'z')
            {
                Console.WriteLine("{0} 是小写字母", chLetter);
                Console.ReadLine();
                return 0;
            }

            //数字判断
            if (Char.IsDigit(chLetter))
            {
                Console.WriteLine("{0} 是数字", chLetter);
                Console.ReadLine();
                return 0;
            }

            Console.WriteLine("{0} 是特殊字符", chLetter);
            Console.ReadLine();
            return 1;
        }
    }
}
