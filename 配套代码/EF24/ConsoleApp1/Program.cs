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

                for (int i = 0; i < 10; i++)
                {
                    dbContext.MyEntities.Add(new MyEntity { Name = "A" + i });
                }

                dbContext.SaveChanges();

                var query = from d in dbContext.MyEntities
                            select d;
                foreach (var item in query)
                {
                    Console.WriteLine("ID:" + item.Id + "\tName:" + item.Name);
                }

                Console.ReadLine();
            }
        }
    }
}
