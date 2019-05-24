using DataBase_Design.Models;
using System.Data.Entity;

namespace DataBase_Design.DAL
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("CollegeStudent")
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SCS> SCSs { get; set; }
        public DbSet <ScoreType> ScoreTypes { get; set; }

        
    }
}