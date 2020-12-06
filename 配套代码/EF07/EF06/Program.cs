using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF06
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
                //foreach (var item in numbers)
                //{
                //    Console.WriteLine(item);
                //}

                //var query =
                //   numbers.Where(num => num.ToString().Contains("1"))
                //   //.OrderBy(num => -num)
                //   .OrderByDescending(num => num.ToString().Length)
                //   .ThenByDescending(num=>num)
                //   .Select(num =>(char)('A'+ num));

                //var query =
                //    numbers.Where(num => num % 2 == 0)
                //    //.OrderBy(num => -num)
                //    .OrderByDescending(num => num)                    
                //    .Select(num => num);

                //var query =
                //    from num in numbers
                //    where num % 2 == 0
                //    select num;
                //foreach (var item in query)
                //{
                //    Console.WriteLine(item);
                //}
            }

            var products = new List<Product>
            {
                    new Product{ProductID=1, ProductCategorry="手机", ProductName="Huawei mate 40 Pro" },
                    new Product{ProductID=2, ProductCategorry="手机", ProductName="iPhone 12 pro Max" },
                    new Product(){ProductID=3, ProductCategorry="手机", ProductName="OPPO K7x" },
                    new Product(){ProductID=4, ProductCategorry="电脑", ProductName="联想 ThinkBook 14" },
                    new Product(){ProductID=5, ProductCategorry="电脑", ProductName="DELL 灵越 5000" },
                    new Product(){ProductID=6, ProductCategorry="鞋子", ProductName="361" },
                    new Product(){ProductID=7, ProductCategorry="服装", ProductName="花花公子" },
                    new Product(){ProductID=8, ProductCategorry="服装", ProductName="稻草人" },
                    new Product(){ProductID=9, ProductCategorry="服装", ProductName="皮尔卡丹" },
                    new Product(){ProductID=10, ProductCategorry="服装", ProductName="南极人" }
            };
            //查询产品，根据名称排序输出
            //var query =
            //    from p in products
            //    orderby p.ProductName ascending
            //    select new { p.ProductID, p.ProductName };

            var query = products
                .OrderByDescending(p => p.ProductName)
                .Select(p=> new { p.ProductID, p.ProductName });
            //投影

            //var query =
            //    from p in products
            //    select new { p.ProductID, p.ProductName } into productList
            //    orderby productList.ProductName descending
            //    select productList;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            //每种产品数量
            //var query =
            //    from p in products
            //    group p by p.ProductCategorry into g
            //    select new { Categorry = g.Key, Count = g.Count() };
            //var query = products
            //    .GroupBy(p=>p.ProductCategorry)
            //    .Select(g=> new { Categorry = g.Key, Count = g.Count() })
            //   ;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}


            //产品分组
            //var query =
            //    from p in products
            //    group p by p.ProductCategorry;
            //var query =
            //    products.GroupBy(p=>p.ProductCategorry);
            //foreach (var item in query)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }

            //    Console.WriteLine();
            //}

            //遍历所有产品信息
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}

            //var query =
            //    from p in products
            //    select p;
            //var query =
            //    products.Select(p=>p);
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            //查找某一类产品
            //var query =
            //    from p in products
            //    where p.ProductCategorry == "手机"
            //    select p;
            //var query =
            //   products.Where(p => p.ProductCategorry == "手机").Select(p=>p.ProductName);

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            Console.Read();
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductCategorry { get; set; }
        public string ProductName { get; set; }

        public override string ToString()
        {
            return "ProductID:\t" + ProductID + Environment.NewLine
                 + "ProductCategorry:\t" + ProductCategorry + Environment.NewLine
                + "ProductName:\t" + ProductName + Environment.NewLine;
        }
    }
}
