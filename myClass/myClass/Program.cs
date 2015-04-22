using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace myClass
{
    class Program
    {
        public class Person
        {
            //枚举类型，用于表示性别。为节省内存，使用byte
            public enum Sex : byte
            { 
                Male=0,Femal
            }

            // 私有属性：姓名，性别，年龄，身高，体重
            private string name;
            private Sex sex;
            private byte age;
            private float heigth;
            private float weigth;

            // 构造函数，只用一个属性：姓名
            public Person(string sName)
            {
                name = sName;
            }

            // 构造函数2，支持两个属性：姓名，性别
            public Person(string sName, Sex cSex)
            {
                name = sName;
                sex = cSex;
            }

            //设置年龄
            public void setAge(byte bAge)
            {
                age = bAge;
            }

            //设置性别，参数为枚举类型Sex
            public void setSex(Sex cSex)
            {
                sex = cSex;
            }

            //重载设置性别方法，参数为byte
            public void setSex(byte bSex)
            {
                sex = (Sex)bSex;
            }

            //设置身高
            public void setHeigth(float fHeigth)
            {
                heigth = fHeigth;
            }

            //设置体重
            public void setWeigth(float fWeigth)
            {
                heigth = fWeigth;
            }

            //得到姓名
            public string getName()
            {
                return name;
            }

            //得到年龄
            public byte getAge()
            {
                return age;
            }

            //得到性别
            public Sex getSex()
            {
                return sex;
            }

            //得到身高
            public float getHeigth()
            {
                return heigth;
            }

            //得到体重
            public float getWeigth()
            {
                return weigth;
            }
        }

        public class myClass
        {
            public static void Main(string[] args)
            {
                // 实例化一个人，设置各项属性
                Person p1 = new Person("李娟");
                p1.setSex((byte)1);
                p1.setAge(19);
                p1.setHeigth((float)1.68);
                p1.setWeigth((float)45);

                // 实例化另一个人，设置各项属性
                Person p2 = new Person("张建国", 0);
                p2.setAge(23);
                p2.setHeigth((float)1.83);
                p2.setWeigth((float)70);

                // 打印出两人的属性
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", p1.getName(), p1.getSex(), p1.getAge(), p1.getHeigth(), p1.getWeigth());

                Console.WriteLine();

                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", p2.getName(), p2.getSex(), p2.getAge(), p2.getHeigth(), p2.getWeigth());

                Console.ReadLine();
            }
        }
    }
}
