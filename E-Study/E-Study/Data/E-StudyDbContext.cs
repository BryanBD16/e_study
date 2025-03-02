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
        public DbSet<Answer> Answers { get; set; }
        public DbSet<CourseResult> CourseResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Désactivez les suppressions en cascade pour certaines relations
            modelBuilder.Entity<Answer>()
                .HasOne(r => r.Question)  // Answer has one Question
                .WithMany()               // Question can have many Answers
                .HasForeignKey(r => r.QuestionId) // Define the foreign key
                .OnDelete(DeleteBehavior.NoAction); // Set delete behavior

            // Define the relationship with SelectedAnswer and set delete behavior
            modelBuilder.Entity<Answer>()
                .HasOne(r => r.SelectedAnswer)  // Answer has one SelectedAnswer (AnswerOption)
                .WithMany()                     // AnswerOption can have many Answers
                .HasForeignKey(r => r.SelectedAnswerId) // Define the foreign key
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
