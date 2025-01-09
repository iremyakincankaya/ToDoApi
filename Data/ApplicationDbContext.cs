using Microsoft.EntityFrameworkCore;

namespace ToDoApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem { Id = 1, Title = ".Net kursu tamamla", Done = false },
                new TodoItem { Id = 2, Title = "CV duzenle", Done = false },
                new TodoItem { Id = 3, Title = "Bitirme ödevini tamamla", Done = false },
                new TodoItem { Id = 4, Title = "Saygınlık kazan", Done = false },
                new TodoItem { Id = 5, Title = "İş bul", Done = false },
                new TodoItem { Id = 6, Title = "Vizeye başvur", Done = false }

            );
        }
    }
}
