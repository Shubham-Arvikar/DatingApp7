using Microsoft.EntityFrameworkCore;
using API.Entities;


namespace API.Data
{
    public class DataContext : DbContext
    {
        // we will be passing connection string as parameter to this constructor
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //dbsets represent tables inside our database -- and columns name will be <App user class> properties
        // we will be injecting constructor of this class in another class to use the data
        // we need to add this datacontext class in the program.cs file
        public DbSet<AppUser> Users { get; set; }
    }
}