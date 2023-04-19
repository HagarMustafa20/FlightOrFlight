using Microsoft.EntityFrameworkCore;
namespace CustomerOrders_Core.Model
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {

        }
        public DbSet<Student> Students  { get; set; }
        public DbSet<Course> Courses  { get; set; }
    }
}
