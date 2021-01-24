using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Student
    {
        public int Id { get; set; }
        public string StuName { get; set; }

        public bool? Gender { get; set; }
        public Nullable<int> ClassId { get; set; }

        public virtual StuClass StuClass { get; set; }
    }
}
