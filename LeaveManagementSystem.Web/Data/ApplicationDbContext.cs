using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData
            (
            new IdentityRole
            {
                Id = "c8330efd-b2b4-463b-a30f-debf9ebb9ecd",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            },
            new IdentityRole
            {
                Id = "db650501-46b7-4c01-a0bf-1c940c665f57",
                Name = "Supervisor",
                NormalizedName = "SUPERVISOR"
            },
            new IdentityRole
            {
                Id = "3dbf33bc-8bd9-4084-8d4d-b622cdc52489",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            }
            );

        var hasher = new PasswordHasher<ApplicationUser>();

        builder.Entity<ApplicationUser>().HasData(new ApplicationUser
        {
            Id = "c84d3b1f-ac0f-4d52-b242-d0913ef35a87",
            Email = "admin@localhost",
            NormalizedEmail = "ADMIN@LOCALHOST",
            UserName = "admin@localhost",
            NormalizedUserName = "ADMIN@LOCALHOST",
            PasswordHash = hasher.HashPassword(null, "SuperPassword1!"),
            EmailConfirmed = true,
            FirstName="Default",
            LastName="Admin",
            DateOfBirth=new DateOnly(1948,1,1)
        });

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId= "3dbf33bc-8bd9-4084-8d4d-b622cdc52489",
                UserId= "c84d3b1f-ac0f-4d52-b242-d0913ef35a87"
            }
            );
    }

    public DbSet<LeaveType> LeaveTypes { get; set; }

}
