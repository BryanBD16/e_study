using E_Study.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Study.Data
{
    public class E_StudyDbContext : DbContext
    {
        public E_StudyDbContext(DbContextOptions<E_StudyDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerOption> AnswerOptions { get; set; }
        public DbSet<Response> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Désactivez les suppressions en cascade pour certaines relations
            modelBuilder.Entity<Response>()
                .HasOne(r => r.Question)
                .WithMany()
                .HasForeignKey(r => r.QuestionId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Response>()
                .HasOne(r => r.SelectedAnswer)
                .WithMany()
                .HasForeignKey(r => r.SelectedAnswerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
