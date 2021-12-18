using Microsoft.EntityFrameworkCore;
using PSEnergyApi.Web.Data.Entities;

namespace PSEnergyApi.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
