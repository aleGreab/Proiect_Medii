using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Mercedes.Models;

namespace Proiect_Mercedes.Data
{
    public class Proiect_MercedesContext : DbContext
    {
        public Proiect_MercedesContext(DbContextOptions<Proiect_MercedesContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Mercedes.Models.Car> Car { get; set; } = default!;
        public DbSet<Proiect_Mercedes.Models.Model_Car> Model { get; set; } = default!;
        public DbSet<Proiect_Mercedes.Models.Motorization> Motorization { get; set; } = default!;
        public DbSet<Proiect_Mercedes.Models.Transmission> Transmission { get; set; } = default!;
        public DbSet<Proiect_Mercedes.Models.State> State { get; set; } = default!;
        public DbSet<Proiect_Mercedes.Models.Member> Member { get; set; } = default!;
        public DbSet<Proiect_Mercedes.Models.Category> Category { get; set; } = default!;

    }
}
