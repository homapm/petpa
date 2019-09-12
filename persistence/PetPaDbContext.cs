using Microsoft.EntityFrameworkCore;
using PetPa.models;

namespace PetPa
{
    public class PetPaDbContext : DbContext
    {
        public PetPaDbContext(DbContextOptions<PetPaDbContext> options) : base(options)
        {

        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}