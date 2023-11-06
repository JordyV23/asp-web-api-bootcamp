using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace read_data
{
    public class ClsAppVentaCursosContext : DbContext
    {
        private const string connectionString = @"";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        // Este DbSet es el que se va a utilizar para hacer las consultas a la base de datos
        // Dieses DbSet wird verwendet, um Abfragen an die Datenbank zu stellen
        public DbSet<ClsCurso> TbCursos { get; set; }
    }
}