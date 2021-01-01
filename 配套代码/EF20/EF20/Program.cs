using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF20
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext=new EF20Entities())
            {
                dbContext.Database.Log = info => Console.WriteLine(info);
                //var result = dbContext.InsertUser("account1", "password1");
                var result = dbContext.GetAccountByID(2).FirstOrDefault();
                if(result!=null)
                {
                    Console.WriteLine(result.Id + "," + result.Account + "," + result.Password);
                }

                //foreach (var item in result)
                //{
                //    Console.WriteLine(item.Id+","+item.Account+","+item.Password);
                //}

                

                Console.ReadLine();


            }
        }
    }
}
