using Microsoft.EntityFrameworkCore;

public class ApplicationDataContext : DbContext
{
    public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options ) : base(options){}
    public DbSet<CategoryModel> Category {get; set;}
    
}