using Microsoft.EntityFrameworkCore;
using HelloWorldAspNetMVC.Models;

namespace HelloWorldAspNetMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PAT1629\SQLEXPRESS;Database=Cursomvc;Integrated Security=True");
        }
    }
}
