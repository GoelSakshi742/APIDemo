using Microsoft.EntityFrameworkCore;

namespace APIDemo.Data
{
    public class ToyDbContext(DbContextOptions<ToyDbContext> options):DbContext(options)
    {
        public DbSet<Toy> Toys => Set<Toy>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Toy>().HasData(new Toy
            {
                Id = 1,
                ToyName = "Millennium Falcon",
                Brand = "LEGO",
                Model = "75257"
            },
            new Toy
            {
                Id = 2,
                ToyName = "Barbie Dreamhouse",
                Brand = "Mattel",
                Model = "FHY73"
            },
            new Toy
            {
                Id = 3,
                ToyName = "Hot Wheels Track Builder",
                Brand = "Mattel",
                Model = "GGH70"
            });
        }
    }
}
