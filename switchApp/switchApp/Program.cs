using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switchApp
{
    class Program
    {
        static void Main()
        {
            //提示
            Console.WriteLine("以下三种选择：");
            Console.WriteLine("             1=(小杯，￥3.0)");
            Console.WriteLine("             2=(中杯，￥4.0)");
            Console.WriteLine("             3=(大杯，￥5.0)");
            Console.Write("您的选择是：");

            //输入选择
            string s = Console.ReadLine();
            int n = int.Parse(s);

            switch (n)
            { 
                case 1:
                    Console.WriteLine("小杯，请付费￥3.0");
                    break;
                case 2:
                    Console.WriteLine("中杯，请付费￥4.0");
                    break;
                case 3:
                    Console.WriteLine("大杯，请付费￥5.0");
                    break;

                default:
                    Console.WriteLine("中杯，请付费￥4.0");
                    break;
            }

            Console.WriteLine("谢谢使用，欢迎再次光临！");
            Console.ReadLine();
        }
    }
}
