using System.Collections.Generic;

namespace ConsoleApp1
{
    public class StuClass
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StuClass()
        {
            this.Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string ClassName { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}