using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Model.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext()
        {

        }

        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options) { }

        public DbSet<Conta> Conta { get; set; }
        //public DbSet<ContaPaga> ContaPaga { get; set; }
        //public DbSet<ContaAPagar> ContaAPagar { get; set; }
    }
}
