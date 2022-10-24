using AutomotivePagingAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutomotivePagingAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //Entities
        public DbSet<Cliente> Clientes { get; set; }
    }
}
