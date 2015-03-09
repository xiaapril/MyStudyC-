using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doWhileApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("欢迎使用doWhileApp V0.1");

            string command;
            
            do
            {
                Console.Write(">");

                command = Console.ReadLine();
                switch (command)
                {
                    case "get":
                        doGet();
                        break;
                    case "put":
                        doPut();
                        break;
                    default:
                        doDefault();
                        break;
                }

            } while (command != "exit");
        }

        private static int doDefault()
        {
            Console.WriteLine("命令错误");

            Console.WriteLine("doWhileApp V0.1 支持的命令集：");
            Console.WriteLine("\tget:\t获取文件");
            Console.WriteLine("\tput:\t传送文件");
            Console.WriteLine("\texit:\t退出程序");

            return 0;
        }

        private static int doPut()
        {
            Console.WriteLine("传送文件...OK");

            return 0;
        }

        private static int doGet()
        {
            Console.WriteLine("获取文件...OK");

            return 0;
        }
    }
}
