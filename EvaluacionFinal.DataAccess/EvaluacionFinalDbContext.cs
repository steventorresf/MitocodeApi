using EvaluacionFinal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionFinal.DataAccess
{
    public class EvaluacionFinalDbContext : DbContext
    {
        public EvaluacionFinalDbContext(DbContextOptions<EvaluacionFinalDbContext> options) :base (options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
