using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OIG.Survey.DLL.Models;

namespace OIG.Survey.DLL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<SurveySession> SurveySessions { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestion { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SurveySession>()
                .HasOne(s => s.Owner)
                .WithMany(u => u.OwnedSurveys)
                .HasForeignKey(s => s.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SurveySession>()
                .HasOne(s => s.AssignedUser)
                .WithMany(u => u.AssignedSurveys)
                .HasForeignKey(s => s.AssignedUserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<UserAnswer>()
                .HasOne(ua => ua.User)
                .WithMany()
                .HasForeignKey(ua => ua.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserAnswer>()
                .HasOne(ua => ua.SurveySession)
                .WithMany(ss => ss.UserAnswers)
                .HasForeignKey(ua => ua.SurveySessionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserAnswer>()
                .HasOne(ua => ua.SurveyQuestion)
                .WithMany()
                .HasForeignKey(ua => ua.SurveyQuestionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
