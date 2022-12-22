using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPlayers
    {
    public class TeamContext : DbContext
        {
        public DbSet<Player> Player { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=TeamDB_02_definitivo_3_0;" +
            "Integrated Security=True;TrustServerCertificate=True");
            }
        }
    }
