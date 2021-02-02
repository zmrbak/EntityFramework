using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF29
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext=new Model1())
            {
                foreach (var item in dbContext.Student)
                {
                    Console.WriteLine($"{item.StuName}\t{item.StuClass.ClassName}");
                }
            }

            Console.ReadLine();

        }
    }
}
