
using Microsoft.EntityFrameworkCore;
using PotterTravel.Model;

namespace PotterTravel.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Cliente>().HasData(  
                new Cliente { Id = 1, Nome = "Joao", Cpf = "123457", Telefone = "36958746",
            Email= "joao@gmail.com", Senha= "444444", ClienteUrl= "localhost8081"},
                new Cliente { Id = 2, Nome = "Maria", Cpf = "123456", Telefone = "36958745",
            Email= "maria@gmail.com", Senha= "333333", ClienteUrl= "localhost8080"}
            );
        }
    }
}
    
