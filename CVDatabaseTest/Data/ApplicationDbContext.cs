using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text.Json;

namespace CVDatabaseTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DemoUser> DemoUser { get; set; }
        public DbSet<Cv> Cvs { get; set; }
        public DbSet<Skill> Skill { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<DemoUser>().HasMany(x => x.Cvs)
                .WithOne(c => c.DemoUser)
                .HasForeignKey(f => f.DemoUserId);

            builder.Entity<SkillCv>()
                .HasKey(x => new { x.CvId, x.SkillId });

            builder.Entity<SkillCv>()
                .HasOne(x => x.Skill)
                .WithMany(x => x.Cvs)
                .HasForeignKey(x => x.SkillId);

            builder.Entity<SkillCv>()
                .HasOne(x => x.Cv)
                .WithMany(x => x.Skills)
                .HasForeignKey(x => x.CvId);

            builder.Entity<Cv>().HasMany(x => x.Educations)
                .WithOne(c => c.Cv)
                .HasForeignKey(f => f.CvId);

            builder.Entity<Cv>().HasMany(x => x.Experiences)
                .WithOne(c => c.Cv)
                .HasForeignKey(f => f.CvId);

            builder.Entity<Cv>().HasMany(x => x.Projects)
                .WithOne(c => c.Cv)
                .HasForeignKey(f => f.CvId);

            builder.Entity<Cv>().HasMany(x => x.References)
                .WithOne(c => c.Cv)
                .HasForeignKey(f => f.CvId);


            builder.Entity<Cv>().Property(x => x.Trainings)
                .HasConversion(
            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
            v => JsonSerializer.Deserialize<ICollection<string>>(v, JsonSerializerOptions.Default))
            .Metadata.SetValueComparer(new ValueComparer<ICollection<string>>(
            (c1, c2) => c1.SequenceEqual(c2),
            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()
             ));


            builder.Entity<Experience>().Property(x => x.Responsibilities)
                .HasConversion(
            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
            v => JsonSerializer.Deserialize<ICollection<string>>(v, JsonSerializerOptions.Default));
        }
    }
}