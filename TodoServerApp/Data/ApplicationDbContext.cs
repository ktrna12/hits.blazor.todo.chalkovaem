using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskItem>().HasData([
                new() {Id = 1, Title="Название 1", Description="Описание 1", CreatedDate=DateTime.Now, FinishedDate=DateTime.Now },
                new() {Id = 2, Title="Название 2", Description="Описание 2", CreatedDate=DateTime.Now, FinishedDate=DateTime.Now },
                new() {Id = 3, Title="Название 3", Description="Описание 3", CreatedDate=DateTime.Now, FinishedDate=DateTime.Now },
                new() {Id = 4, Title="Название 4", Description="Описание 4", CreatedDate=DateTime.Now, FinishedDate=DateTime.Now }
            ]);
        }   
    }
}
