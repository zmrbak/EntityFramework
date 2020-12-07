using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF10
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 12, 24, 35, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var query =
                from num in numbers
                select num;

            var a1 = query.ToList();
            var b1 = numbers.ToList();

            var a2 = query.ToArray();
            var b2 = numbers.ToArray();

            var a3 = query.ToDictionary(num =>
            {
                int index = -1;
                foreach (var item in numbers)
                {
                    index++;
                    if (item == num)
                    {
                        return index;
                    }
                }
                return index;
            }, num => num);
            var b3 = numbers.ToDictionary(num => num);

            var a4 = query.ToHashSet();
            var b4 = numbers.ToHashSet();

            var a5 = query.ToLookup(num =>
            {
                int index = -1;
                foreach (var item in numbers)
                {
                    index++;
                    if (item == num)
                    {
                        return index % 3;
                    }
                }
                return index;
            }, num => num);

            //foreach (var item in a5)
            //{
            //    Console.WriteLine(item.Key);

            //    foreach (var str in item)
            //    {
            //        Console.WriteLine("    {0}", str);
            //    }                    
            //}

            var a6 = numbers.AsEnumerable();
            var a7 = numbers.AsQueryable();
            var a8 = numbers.AsParallel();
            var a9 = numbers.Cast<long>();
            var a10 = numbers.OfType<object>();

            var persons = new Parent[] {new Parent(), new Parent(), new Son(), new Son() };
            var a11 = persons.OfType<Parent>();
            var a12 = persons.OfType<Son>();
        }
    }

    public class Spamle2 : IQueryable<int>
    {
        public Expression Expression => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Sapmle : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Parent
    {
    }

    public class Son:Parent
    {
    }
}
