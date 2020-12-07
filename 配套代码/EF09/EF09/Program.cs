using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF09
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldNumbers = new int[] { 99, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var oldNumbers = new int[] { /*99, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10*/ };
            //var numbers =
            //    from num in oldNumbers
            //    select num;

            //var a = numbers.Count(num=>num%2==0);
            //var b = numbers.Max();
            //var c = numbers.Min();
            //var d = numbers.Average();
            //var e = numbers.Sum();

            //var f =
            //   (from num in oldNumbers
            //   select num).Sum();

            //var a1 = oldNumbers.ElementAt(12);
            //var a1 = oldNumbers.ElementAtOrDefault(12);
            //var a1 = oldNumbers.FirstOrDefault();
            //var a1 = oldNumbers.LastOrDefault();
            //int[] aa = null;
            //var a1 = aa.LastOrDefault();
            //var a1 = oldNumbers.Single();
            var a1 = oldNumbers.SingleOrDefault();
        }
    }
}
