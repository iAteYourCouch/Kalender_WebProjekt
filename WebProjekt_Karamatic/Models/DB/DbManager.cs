using Microsoft.EntityFrameworkCore;

namespace WebProjekt_Karamatic.Models.DB {
    public class DbManager : DbContext{

        public DbSet<User> Users { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // für den Pomelo-MySQL-Treiber
            string connectionString = "Server=localhost;database=kalender_projekt;user=root;password=root";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
