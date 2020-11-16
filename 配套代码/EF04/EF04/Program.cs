using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //foreach (var item in list)
            //{
            //}

            var users = new List<User>
            {
                new User{ Name="张三",Age=18},
                new User{ Name="李四",Age=17},
                new User{ Name="王五",Age=21},
                new User{ Name="马六",Age=23}
            };

            var users1= users.GetList(20);
            foreach (var item in users1)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
        static void Main1(string[] args)
        {
            string a = "asd889asdasd767LJjlsad";
            Console.WriteLine(a.Length);
            Console.WriteLine(a.StrCount());

            Console.WriteLine(a.StrCount(true));
            Console.WriteLine(MyStringExt.StrCount(a));
            Console.WriteLine(MyStringExt.StrCount(a, true));
            Console.ReadLine();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public static class MyStringExt
    {
        public static int StrCount(this string @this)
        {
            return @this.Length;
        }

        public static int StrCount(this string @this, bool half)
        {
            if (half == true)
            {
                return @this.Length / 2;
            }
            else
            {
                return @this.Length;
            }
        }

        public static IEnumerable<User> GetList(this List<User> @this,int aboveAge=0)
        {
            foreach (var item in @this)
            {
                if(item.Age>= aboveAge)
                {
                    yield return item;
                    //yield break;
                }
            }
        }
    }
}
