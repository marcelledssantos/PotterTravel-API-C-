using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotterTravel.Data
{
    public class DataContext : DataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}