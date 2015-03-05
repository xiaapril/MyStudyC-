using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName;
            Console.Write("please input your name:");
            strName = Console.ReadLine();
            Console.WriteLine("hello,{0}!",strName);
        }
    }
}
