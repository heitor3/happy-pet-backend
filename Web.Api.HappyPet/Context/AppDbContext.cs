using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.HappyPet.Models;

namespace Web.Api.HappyPet.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
             
        }

        public DbSet<Especie> Especie { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Porte> Porte { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
