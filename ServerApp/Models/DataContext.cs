using Microsoft.EntityFrameworkCore;

namespace ServerApp.Models {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) {}

        public DbSet<Question> Questions {get; set; }
        public DbSet<Quiz> Quizzes {get; set;}
    }
}