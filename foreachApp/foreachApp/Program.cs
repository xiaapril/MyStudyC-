using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace foreachApp
{
    class Program
    {
        static void Main()
        {
            //把环境变量中所有值取出来，放到变量environment
            IDictionary environment = Environment.GetEnvironmentVariables();

            //打印表头
            Console.WriteLine("环境变量名\t=\t环境变量值");

            //遍历environment中所有键值
            foreach (string environmentKey in environment.Keys)
            {
                //打印出所有变量环境的名称和值
                Console.WriteLine("{0}\t=\t{1}", environmentKey, environment[environmentKey].ToString());
            }

            Console.ReadLine();
        }
    }
}
