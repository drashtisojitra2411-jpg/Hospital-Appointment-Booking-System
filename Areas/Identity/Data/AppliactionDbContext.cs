using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ResilienceLifescapeHospital.Areas.Identity.Data;

public class AppliactionDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
{
    public AppliactionDbContext(DbContextOptions<AppliactionDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doctor> Doctors { get; set; }
    public virtual DbSet<Patient> Patients { get; set; }
    public virtual DbSet<ApplicationUser> User { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Doctor>()
            .HasOne(d => d.ApplicationUser)
            .WithMany()
            .HasForeignKey(d => d.UserId)
            .IsRequired();

        // Configure Patient-User relationship
        builder.Entity<Patient>()
            .HasOne(p => p.ApplicationUser)
            .WithMany()
            .HasForeignKey(p => p.UserId)
            .IsRequired();

            builder.Entity<ApplicationRole>().HasData(new ApplicationRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
    }
}
