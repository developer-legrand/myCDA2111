using ApiCereals.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCereals
{
    public class CearealDbContext : DbContext       
    {
        public DbSet<Cereal> Cereals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(LocalDB)\mssqllocaldb;Database=dbCereals");
        }
    }
}
