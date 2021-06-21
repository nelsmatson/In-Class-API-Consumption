using Microsoft.EntityFrameworkCore;
using In_Class_API_Consumption.Models;

namespace In_Class_API_Consumption.DataAccess
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Parks> Parks { get; set; }
    public DbSet<Park> Park { get; set; }
  }
}