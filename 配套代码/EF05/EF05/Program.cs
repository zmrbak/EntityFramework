using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF05
{
    //public delegate void DelegateFun(string str);
    public delegate void DelegateFun(string str1, string str2, string str3);
    public class Test
    {
        //public void Fun1(string str)
        //{
        //    Console.WriteLine("Hello," + str);
        //}

        public void Speak()
        {
            //DelegateFun delegateFun = new DelegateFun(Fun1);
            //DelegateFun delegateFun = new DelegateFun((x) => Console.WriteLine("Hello," + x));

            //DelegateFun delegateFun = new DelegateFun(x => Console.WriteLine("Hello," + x));
            //DelegateFun delegateFun = new DelegateFun(x => 
            //{ 
            //    Console.WriteLine("Hello," + x);
            //    Console.WriteLine("Hello2," + x);
            //});

            //DelegateFun delegateFun = new DelegateFun((x,y,z)=>
            //{
            //    Console.WriteLine("Hello," + x);
            //    Console.WriteLine("Hello2," + y);
            //    Console.WriteLine("Hello3," + z);
            //});

            //var delegateFun=new Action<string,string,string>((x, y, z) =>
            //{
            //    Console.WriteLine("Hello," + x);
            //    Console.WriteLine("Hello2," + y);
            //    Console.WriteLine("Hello3," + z);
            //});
            //delegateFun("张三","李四","王五");


            new Action<string, string, string>((x, y, z) =>
            {
                Console.WriteLine("Hello," + x);
                Console.WriteLine("Hello2," + y);
                Console.WriteLine("Hello3," + z);
            })("张三", "李四", "王五");

            //Func<string,string,>
            //Predicate<string>
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Speak();

            Console.Read();
        }
    }
}
