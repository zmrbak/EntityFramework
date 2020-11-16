using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03
{
    public delegate int Add(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //string b = "test";

            //var a = 1;
            //var b = "test";

            //错误示范 1
            //var a;
            //a = 1;

            //错误示范 2
            //var a = 1;
            //a = "test";

            //User user = new User();
            //user.Age = 18;
            //user.Name = "张三";
            //user.Gender = true;

            //User user = new User() { Name = "张三", Gender = true, Age = 18 };

            //User user = new User 
            //{ 
            //    Name = "张三", 
            //    Gender = true,
            //    Age = 18 
            //};

            //var user = new User
            //{
            //    Name = "张三",
            //    Gender = true,
            //    Age = 18
            //};

            //var user = new 
            //{
            //    Name = "张三",
            //    Gender = true,
            //    Age = 18
            //};

            //var user2 = new
            //{
            //    Age = 19,
            //    Name = "王五",
            //    Gender = false               
            //};

            //只读
            //user.Age = 19;

            //Console.WriteLine("姓名:\t"+user.Name);
            //Console.WriteLine("年龄:\t" + user.Age);
            //Console.WriteLine("性别:\t" + user.Gender);

            //Console.WriteLine(user.GetType());
            //Console.WriteLine(user2.GetType());
            //string a = "test";
            //Console.WriteLine(a.GetType());

            //Add add = new Add(MyAdd);
            Add add = delegate (int x1, int y1)
            {
                return x1 + y1;
            };


            int c = add(1, 2);
            Console.WriteLine(c);


            Console.ReadLine();
        }
        public static int MyAdd(int x, int y)
        {
            return x + y;
        }

    }

    //public class User
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public bool Gender { get; set; }
    //}
}
