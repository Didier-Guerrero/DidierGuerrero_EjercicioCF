using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DidierGuerrero_EjercicioCF.Models;

namespace DidierGuerrero_EjercicioCF.Data
{
    public class DidierGuerrero_EjercicioCFContext : DbContext
    {
        public DidierGuerrero_EjercicioCFContext (DbContextOptions<DidierGuerrero_EjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<DidierGuerrero_EjercicioCF.Models.Burger> Burger { get; set; } = default!;
    }
}
