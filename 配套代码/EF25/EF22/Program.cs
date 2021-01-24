using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF22
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new EF22Entities())
            {
                dbContext.Database.Log = info => Console.WriteLine(info);

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


                //var temp1 = dbContext.StuClasses.Where(x => x.Id == 1);
                //var temp1 = dbContext.StuClasses.Where(x => x.Id == 2);
                //foreach (var item in temp1)
                //{
                //    //Console.WriteLine(item.Id+","+item.ClassName);

                //    foreach (var item1 in item.Students)
                //    {
                //        //Console.WriteLine(item1.ClassId+","+item1.Id+","+item1.StuName);

                //        Console.WriteLine(item1.StuClass.ClassName + "," + item1.Id + "," + item1.StuName);
                //    }
                //}

                Console.ReadLine();

            }
        }
    }
}
