using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new Model1())
            {
                dbContext.Database.Log = info => Console.WriteLine(info);

                //for (int i = 0; i < 10; i++)
                //{
                //    dbContext.MyEntities.Add(new MyEntity { Name = "A" + i });
                //}

                //dbContext.SaveChanges();

                //var query = from d in dbContext.MyEntities
                //            select d;
                //foreach (var item in query)
                //{
                //    Console.WriteLine("ID:" + item.Id + "\tName:" + item.Name);
                //}

                var stuClass1 = new StuClass { ClassName = "五年级" };
                dbContext.StuClasses.Add(stuClass1);
                dbContext.Students.Add(new Student { StuClass = stuClass1, StuName = "zmrbak_1" });
                dbContext.Students.Add(new Student { StuClass = stuClass1, StuName = "zmrbak_2" });
                dbContext.SaveChanges();

                foreach (var item in dbContext.StuClasses)
                {
                    Console.WriteLine(item.Id + "," + item.ClassName);
                }

                foreach (var item in dbContext.Students)
                {
                    Console.WriteLine(item.Id + "," + item.StuName + "," + item.ClassId + "," + item.StuClass.ClassName);
                }

                Console.ReadLine();
            }
        }
    }
}
