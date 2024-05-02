using Crud.Infraestructure.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Crud.Infraestructure.Data.Context;

/// <summary>
/// Database Context.
/// </summary>
public sealed class DatabaseContext : DbContext
{
    private readonly IConfiguration _configuration;

    /// <summary>
    /// Database Context.
    /// </summary>
    /// <param name="configuration"></param>
    public DatabaseContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// Users.
    /// </summary>
    public DbSet<Users>? Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: _configuration["ConnectionStrings:DatabaseName"]);
    }
}