using Microsoft.EntityFrameworkCore;
 
namespace Csharp_CRUDelicious.Models
{
    public class DishContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DishContext(DbContextOptions<DishContext> options) : base(options) { }

        // This DbSet contains "Dish" objects and is called "Dishes" = db table name
        public DbSet<Dish> Dishes { get; set; }
    }
}