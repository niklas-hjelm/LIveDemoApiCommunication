using Microsoft.EntityFrameworkCore;

namespace LIveDemoApiCommunication.DataAccess;

public class PeopleDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    public PeopleDbContext(DbContextOptions options): base(options)
    {
        
    }
}