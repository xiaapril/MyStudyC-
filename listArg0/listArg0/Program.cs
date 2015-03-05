using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listArg0
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName;     //声明一个string类型的值的变量
            string[] list = new string[]{"red","yellow"};
            strName = list[0];  //把第一个参数赋值给变量strName
            Console.WriteLine("This is the first argument:{0}", strName);
            Console.Read();
        }
    }
}
