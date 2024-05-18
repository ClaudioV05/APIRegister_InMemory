using Crud.Infraestructure.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.Infraestructure.Data.Context;

/// <summary>
/// Database Context.
/// </summary>
public sealed class DatabaseContext : DbContext
{
    /// <summary>
    /// Database Context.
    /// </summary>
    public DatabaseContext() { }

    /// <summary>
    /// Users.
    /// </summary>
    public DbSet<Users>? Users { get; set; }
}