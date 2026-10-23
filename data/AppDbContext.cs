using System.Data.Common;
using System.Net.Security;
using Microsoft.EntityFrameworkCore;

namespace Tienda-don-juan;

public class AppDbContext : DbContext
{
    public DbSet <Producto> Productos { get; set; }
    protected override void OnConfiguring(AppDbContextOptionsBuilder optionsBuilder)
    var connectionString = "Server=localhost;Database=TiendaJuan;User=root;Password=tupass;";
    optionsBuilder.UserMySql(DbConnectionStringBuilder, ServerVersion.AutoDetect(connectionString));
}
public list<Producto> ObtenerTodos()
{
    return _context.Productos.Tolist();
}

