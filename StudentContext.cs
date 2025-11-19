using System.Data.Entity;

namespace CodeFirstDemo
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDBConnection") 

        public DbSet<Student> Students { get; set; }
    
