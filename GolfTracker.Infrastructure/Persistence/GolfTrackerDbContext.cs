using Microsoft.EntityFrameworkCore;
using GolfTracker.Core.Entities;

namespace GolfTracker.Infrastructure.Persistence
{
    public class GolfTrackerDbContext : DbContext
    {
        public GolfTrackerDbContext(DbContextOptions<GolfTrackerDbContext> options) : base(options) { }

        public DbSet<GolfCourse> GolfCourses { get; set; }
        public DbSet<GolfScore> GolfScores { get; set; }
        public DbSet<HoleScores> HoleScores { get; set; }
        public DbSet<GolfCourseHole> GolfCourseHoles { get; set; } // Add DbSet for GolfCourseHole

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure GolfScore and HoleScores relationship
            modelBuilder.Entity<GolfScore>()
                .HasMany(gs => gs.HoleScores)
                .WithOne()
                .HasForeignKey(hs => hs.GolfScoreId) // Specify foreign key
                .OnDelete(DeleteBehavior.Cascade); // Specify delete behavior

            // Configure HoleScores entity
            modelBuilder.Entity<HoleScores>()
                .HasKey(h => h.Id); // Set the primary key

            // Configure GolfCourse and GolfCourseHole relationship
            modelBuilder.Entity<GolfCourse>()
                .HasMany(gc => gc.Holes)
                .WithOne()
                .HasForeignKey(gch => gch.GolfCourseId) // Specify foreign key
                .OnDelete(DeleteBehavior.Cascade); // Specify delete behavior

            // Configure GolfCourseHole entity
            modelBuilder.Entity<GolfCourseHole>()
            .HasKey(h => new { h.GolfCourseId, h.HoleNumber });
        }
    }
}
