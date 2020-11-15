using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    //申明委托
    public delegate string TestDelegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //TestDelegate testDelegate1 = new TestDelegate(Test1);
            //string a=testDelegate1("zqm");
            //Console.WriteLine(a);

            //C# 2.0
            //TestDelegate testDelegate1 = Test1;
            //string a = testDelegate1("zqm");
            //Console.WriteLine(a);

            //TestDelegate testDelegate1 = Test1;
            //string a = testDelegate1.Invoke("zqm");
            //Console.WriteLine(a);

            //TestDelegate testDelegate2 = new TestDelegate(Test2);
            //testDelegate2 += new TestDelegate(Test1);
            //string b=testDelegate2("赵庆明");
            //Console.WriteLine("b:\t"+b);

            //TestDelegate testDelegate2 =Test2;
            //testDelegate2 += Test1;
            //testDelegate2 -= Test2;
            //testDelegate2 -= Test2;
            //string b = testDelegate2("赵庆明");
            //Console.WriteLine("b:\t" + b);

            User user = new User();
            user.TackAction(Action1);
            user.TackAction(Action2);

        }

        static void Action1()
        {
            Console.WriteLine("Action1");
        }


        static void Action2()
        {
            Console.WriteLine("Action2");
        }

        static string Test1(string name)
        {
            string result= "Hello,"+name;
            Console.WriteLine(result);
            return result;
        }
        static string Test2(string name)
        {
            string result = "你好," + name;
            Console.WriteLine(result);
            return result;
        }
    }

    public class User
    {
        public delegate void UserAction();
        public void TackAction(UserAction userAction)
        {
            //userAction.Invoke();
            userAction();
        }
    }
}
