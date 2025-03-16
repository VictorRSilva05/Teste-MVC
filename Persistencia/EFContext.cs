using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class EFContext : DbContext
    {
        public DbSet<Curso> Cursos {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("@Server=(localdb)\\mssqllocaldb; Database=ADO_NETDatabase; Trusted_Connection=True;");
        }
    }
}
