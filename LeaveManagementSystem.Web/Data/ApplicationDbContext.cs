using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       //Default role values basically, you can use this for any other entity if you want the database to have default values
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole 
                {
                    // since we're seeding data, the dbcontext will allow the ID's wo be insterted  
                    Id = "4773b096-25de-44f8-ad56-64fe1410695e",
                    Name= "Employee",
                    NormalizedName= "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "05afcd56-4f48-49cd-8dfc-87daf49a4ed5",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole
                {
                    Id = "278cfc70-3750-4469-9542-8df20d978aae",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
                );

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "3477060b-f3a7-407a-bb83-033332353800",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(2001, 12, 06) 
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> 
            {
                RoleId = "278cfc70-3750-4469-9542-8df20d978aae",
                UserId = "3477060b-f3a7-407a-bb83-033332353800"

            }
            );
        }
        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
