using Microsoft.EntityFrameworkCore;

namespace CRAC.Api.SQLite {
    public class CracContext : DbContext {
        public DbSet<Moviment> Moviments { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite ("Data Source=crac.db");
        }
    }

    public class Moviment {
        public int MovimentId { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
        public int Claw { get; set; }
        public int Base { get; set; }
    }
}