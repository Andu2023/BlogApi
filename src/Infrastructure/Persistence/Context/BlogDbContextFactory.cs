using System;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence.Contexts;

public class BlogDbContextFactory : IDesignTimeDbContextFactory<BlogDbContext>
{
    public BlogDbContext CreateDbContext(string[] args)
    
    {
      var optionsBuilder= new DbContextOptionsBuilder<BlogDbContext>();
      optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=BlogDb; Trusted_Connection=True; TrustServerCertificate=True;");
      return new BlogDbContext(optionsBuilder.Options);
        
    }
}
