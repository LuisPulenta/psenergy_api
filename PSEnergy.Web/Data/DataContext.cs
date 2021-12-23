using Microsoft.EntityFrameworkCore;
using PSEnergy.Web.Data.Entities;

namespace PSEnergy.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Usuario> SubContratistasUsrWebs { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Yacimiento> Yacimientos { get; set; }
        public DbSet<Bateria> Baterias { get; set; }
        public DbSet<Pozo> Pozos { get; set; }
    }
}
