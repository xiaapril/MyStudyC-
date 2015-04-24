using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rectangle
{
    public class Rectangle
    {
        private int iHeigth;
        private int iWidth;

        // 缺省构造函数 
        public Rectangle()
        {
            iHeigth = 0;
            iWidth = 0;
        }

        // 构造函数重载
        public Rectangle(int h, int w)
        {
            iHeigth = h;
            iWidth = w;
        }

        // 属性：高 的get和set访问器
        public int Heigth
        {
            get { return iHeigth; }
            set { iHeigth = value; }
        }

        // 属性：宽 的get和set访问器
        public int Width
        {
            get { return iWidth; }
            set { iWidth = value; }
        }

        // 属性：面积 的get访问器
        public int Area
        {
            get
            {
                return Heigth * Width;
            }
        }

        // 重载操作符 ==
        public static bool operator ==(Rectangle a, Rectangle b)
        {
            return ((a.Heigth == b.Heigth) && (a.Width == b.Width));
        }

        // 重载操作符 != 
        public static bool operator !=(Rectangle a, Rectangle b)
        {
            return !(a == b);
        }

        // 重载操作符 >
        public static bool operator >(Rectangle a, Rectangle b)
        {
            return a.Area > b.Area;
        }

        // 重载操作符 <
        public static bool operator <(Rectangle a, Rectangle b)
        {
            return !(a > b);
        }

        // 重载操作符 >=
        public static bool operator >=(Rectangle a, Rectangle b)
        {
            return (a > b) || (a == b);
        }

        // 重载操作符 <=
        public static bool operator <=(Rectangle a, Rectangle b)
        {
            return (a < b) || (a == b);
        }

        // 重载ToString
        public override string ToString()
        {
            return "高=" + Heigth + ",宽=" + Width;

        }

        public static void Main()
        {
            // 实例化三个矩形并设置各自属性
            Rectangle objRect1 = new Rectangle();
            Rectangle objRect2 = new Rectangle();
            Rectangle objRect3 = new Rectangle(10, 15);
            objRect1.Heigth = 15;
            objRect1.Width = 10;
            objRect2.Heigth = 25;
            objRect2.Width = 10;

            // 打印三个矩形的信息
            // 其中调用了ToString方法
            Console.WriteLine("矩形#1 " + objRect1);
            Console.WriteLine("矩形#2 " + objRect2);
            Console.WriteLine("矩形#3 " + objRect3);

            // 使用重载后的操作符比较矩形并打印结果
            if (objRect1 == objRect2)
            {
                Console.WriteLine("矩形#1和矩形#2高和宽都相等");
            }
            else
            {
                if (objRect1 > objRect2)
                {
                    Console.WriteLine("矩形1大于矩形2");
                }
                else
                {
                    Console.WriteLine("矩形1小于于矩形2");
                }
            }

            if (objRect1 == objRect3)
            {
                Console.WriteLine("矩形1等于矩形3");
            }
            else
            {
                Console.WriteLine("矩形1不等于矩形3");
            }

            Console.ReadLine();
        }
    }
}
