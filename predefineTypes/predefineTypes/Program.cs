using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace predefineTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "this is a string";
            Console.WriteLine(str);
            string strCopy = string.Copy(str);
            Console.WriteLine(strCopy);
            bool testbool = (str == strCopy);
            Console.WriteLine(testbool);
            testbool = ((object)str == (object)strCopy);
            Console.WriteLine(testbool);
            float testfloat = 23223.03F;
            Console.WriteLine(testfloat);
            double testdouble = 2323.03D;
            Console.WriteLine(testdouble);
            testbool = (testfloat == testdouble);
            Console.WriteLine(testbool);
            Console.ReadLine();
        }
    }
}
