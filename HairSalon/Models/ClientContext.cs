using Microsoft.EntityFrameworkCore;

namespace FavoriteClient.Models
{
  public class FavoriteClientContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }
    public FavoriteClientContext(DbContextOptions options) : base(options) { }
  }
}
