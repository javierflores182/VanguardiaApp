using Microsoft.EntityFrameworkCore;
using tarea1.api.Models;

namespace tarea1.api.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }
    }
}