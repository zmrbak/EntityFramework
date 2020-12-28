using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF13
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new EF13Entities())
            {
                dbContext.Database.Log = info => Console.WriteLine(info); //WriteLog;

                string sql = "DROP TABLE Test";
                var result = dbContext.Database.ExecuteSqlCommand(sql);
                Console.WriteLine(result);

                //string sql = "delete from Test";
                //var result = dbContext.Database.ExecuteSqlCommand(sql);
                //Console.WriteLine(result);

                //string sql = "UPDATE Test SET Password=@Password WHERE Account=@Account";
                //SqlParameter[] sqlParameters = {
                //    new SqlParameter("@Account","Account"),
                //    new SqlParameter("@Password","11111111")
                //};
                //var result = dbContext.Database.ExecuteSqlCommand(sql, sqlParameters);
                //Console.WriteLine(result);

                //string sql = "INSERT INTO Test(Account,Password) VALUES(@Account,@Password)";
                ////SqlParameter[] sqlParameters = new SqlParameter[] {
                ////    new SqlParameter("@Account","MyAccount"),
                ////    new SqlParameter("@Password","MyPassword")
                ////};
                //SqlParameter[] sqlParameters = {
                //    new SqlParameter("@Account","MyAccount1"),
                //    new SqlParameter("@Password","MyPassword1")
                //};
                //var result = dbContext.Database.ExecuteSqlCommand(sql, sqlParameters);
                //Console.WriteLine(result);

                //string sql = "INSERT INTO Test(Account,Password) VALUES('Account','Password')";
                //var result = dbContext.Database.ExecuteSqlCommand(sql);
                //Console.WriteLine(result);


                //                string sql = @"
                //CREATE TABLE [dbo].[Test] (
                //    [Id]     INT        IDENTITY (1, 1) NOT NULL,
                //    [Account]   VARCHAR (10) NULL,
                //    [Password] VARCHAR (20) NULL
                //    PRIMARY KEY CLUSTERED ([Id] ASC)
                //);";
                //                var result = dbContext.Database.ExecuteSqlCommand(sql);
                //                Console.WriteLine(result);

                //添加
                //SampleTable sampleTable = new SampleTable { Age = 18, Gender = true, Name = "张三" };
                //dbContext.SampleTable.Add(sampleTable);
                //dbContext.SaveChanges();

                //添加多个
                //List<SampleTable> sampleTables = new List<SampleTable> {
                // new SampleTable{ Age=17,Gender=true,Name="A1" },
                // new SampleTable{ Age=18,Gender=true,Name="A2" },
                // new SampleTable{ Age=19,Gender=false,Name="A3" },
                // new SampleTable{ Age=20,Gender=true,Name="A4" },
                // new SampleTable{ Age=21,Gender=false,Name="A5" }
                //};
                //dbContext.SampleTable.AddRange(sampleTables);

                //查询
                //var temp = dbContext.SampleTable.Find(3);

                //根据年龄范围查询
                //var temp = dbContext.SampleTable.Where(x => x.Age >= 17 && x.Age <= 20);
                //var temp = from d in dbContext.SampleTable
                //           where d.Age >= 17 && d.Age <= 20
                //           select d;
                //foreach (var item in temp)
                //{
                //    Console.WriteLine(item.Id + "," + item.Name + "," + item.Age + "," + item.Gender);
                //}

                //删除一个
                //dbContext.SampleTable.Remove(temp);

                //删除多个
                //var temp = dbContext.SampleTable.Where(x => x.Age == 18);
                //dbContext.SampleTable.RemoveRange(temp);

                //更新
                //var temp = dbContext.SampleTable.Where(x => x.Age >= 17 && x.Age <= 20);
                //var list = temp.ToList();
                //for (int i = 0; i < list.Count; i++)
                //{
                //    list[i].Gender = true;
                //}

                //foreach (var item in temp)
                //{
                //    item.Gender = true;
                //}



                //SampleTable sampleTable = new SampleTable { Age = 18, Gender = true, Name = "张三" };
                //eF13Entities.SampleTable.Add(sampleTable);
                //eF13Entities.SampleTable.Remove(temp);
                //temp.Name = "李四";

                //dbContext.SaveChanges();
            }

            Console.WriteLine("执行完毕");
            Console.ReadLine();
        }

        //private static void WriteLog(string obj)
        //{
        //    Console.WriteLine(obj);
        //}
    }
}
