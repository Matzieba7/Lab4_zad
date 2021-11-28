using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solucja4_zad.Models;

namespace Solucja4_zad.Data
{
    public class Solucja4_zadContext : DbContext
    {
        public Solucja4_zadContext (DbContextOptions<Solucja4_zadContext> options)
            : base(options)
        {
        }

        public DbSet<Solucja4_zad.Models.Game> Game { get; set; }
    }
}
