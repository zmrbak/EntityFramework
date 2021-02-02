using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EF29
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<StuClass> StuClass { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StuClass>()
                .Property(e => e.ClassName)
                .IsFixedLength();

            modelBuilder.Entity<StuClass>()
                .HasMany(e => e.Student)
                .WithOptional(e => e.StuClass)
                .HasForeignKey(e => e.ClassId);

            modelBuilder.Entity<Student>()
                .Property(e => e.StuName)
                .IsFixedLength();
        }
    }
}
