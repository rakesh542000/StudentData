using StudentDataBase.Model;
using System.Collections.Generic;
using System.Reflection;


namespace StudentDataBase.Data
{
    public class StudentDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<Model.Student> Students { get; set; }
        public DbSet<Marksheet> Marksheets { get; set; }
    }
}
