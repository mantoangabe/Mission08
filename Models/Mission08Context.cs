using Microsoft.EntityFrameworkCore;

namespace Mission08.Models;

public class Mission08Context : DbContext
{
    public Mission08Context(DbContextOptions<Mission08Context> options) : base(options)
    {
        
    }
    public DbSet<Task> Tasks { get; set; }
}