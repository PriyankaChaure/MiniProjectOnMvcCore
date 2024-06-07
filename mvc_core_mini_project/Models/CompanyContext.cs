using Microsoft.EntityFrameworkCore;

namespace mvc_core_mini_project.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
