using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaNetCore.Models
{
    public class SistemaNetCoreContext : DbContext
    {
        public SistemaNetCoreContext (DbContextOptions<SistemaNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
    }
}
