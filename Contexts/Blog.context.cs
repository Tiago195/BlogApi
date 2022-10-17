using Microsoft.EntityFrameworkCore;
using Blog.Model;

namespace Blog.Context;

public class BlogContext : DbContext
{
  public DbSet<User> Users { get; set; }
  public DbSet<Category> Categories { get; set; }
  public DbSet<BlogPost> BlogPosts { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=BlogApi;User=SA;Password=<YourStrong@Passw0rd>;");
  }
}