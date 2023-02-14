using System;
using DockerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerApp.Data;

public class ApiDbContext : DbContext
{
  public ApiDbContext(DbContextOptions<ApiDbContext> options)
      : base(options)
  {

  }
  public DbSet<Driver> Drives { get; set; }
}

