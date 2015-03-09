using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace whileApp
{
    class Program
    {
        //这是一个支持单用户的服务器模型
        static void Main()
        {
            Console.WriteLine("欢迎使用whileApp V0.1");

            //打印命令输入符
            Console.Write(">");

            //用于存储命令
            string command; 

            while ((command = Console.ReadLine()) != "exit")
            {
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

                Console.Write(">");
            }
        }

        private static int doDefault()
        {
            //打印出错信息
            Console.WriteLine("命令错误");

            //提示正确用法
            Console.WriteLine("whileApp V0.1 支持的命令集有：");
            Console.WriteLine("\tget:\t获取文件");
            Console.WriteLine("\tput:\t传送文件");
            Console.WriteLine("\texit:\t退出程序");

            return 0;
        }

        //处理Put命令
        private static int doPut()
        {
            //待加入真正的Put处理动作
            Console.WriteLine("传送文件...OK");

            return 0;
        }

        //处理Get命令
        private static int doGet()
        {
            //待加入真正的Get处理动作
            Console.WriteLine("获取文件...OK");

            return 0;
        }
    }
}
