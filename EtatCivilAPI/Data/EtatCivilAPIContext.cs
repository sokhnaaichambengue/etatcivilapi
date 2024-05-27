using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EtatCivilAPI.Models;

namespace EtatCivilAPI.Data
{
    public class EtatCivilAPIContext : DbContext
    {
        public EtatCivilAPIContext (DbContextOptions<EtatCivilAPIContext> options)
            : base(options)
        {
        }

        public DbSet<EtatCivilAPI.Models.Death> Death { get; set; } = default!;
    }
}
