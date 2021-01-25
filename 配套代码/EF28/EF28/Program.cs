using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF28
{
    class Program
    {
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        static void Main(string[] args)
        {
            using (var dbContext=new Model1Container())
            {
                dbContext.Database.Log = info => Console.WriteLine(info);

                var c = dbContext.ProductSet.Count();
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
}
