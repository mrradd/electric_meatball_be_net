using Microsoft.EntityFrameworkCore;

public class EmDbContext : DbContext
{
    public EmDbContext(DbContextOptions<EmDbContext> options)
        : base(options)
    {
    }
}