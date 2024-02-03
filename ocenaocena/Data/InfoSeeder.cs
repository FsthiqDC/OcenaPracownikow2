using ocenaocena.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ocenaocena.Data;

namespace ocenaocena.data
{
    public class InfoSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))

                if (dbContext.Database.CanConnect())
                {
                    SeedRoles(dbContext);
                    SeedUsers(dbContext);
                    


                }
        }

        //zakładanie ról w apliakcji, o ile nie istnieją
        private static void SeedRoles(ApplicationDbContext dbContext)
        {
            var roleStore = new RoleStore<IdentityRole>(dbContext);

            if (!dbContext.Roles.Any(r => r.Name == "admin"))
            {
                roleStore.CreateAsync(new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                }).Wait();
            }

            if (!dbContext.Roles.Any(r => r.Name == "pracownik"))
            {
                roleStore.CreateAsync(new IdentityRole
                {
                    Name = "pracownik",
                    NormalizedName = "pracownik"
                }).Wait();
            }
        }  // koniec ról

        //zakładanie kont uzytkowników w apliakcji, o ile nie istnieją
        private static void SeedUsers(ApplicationDbContext dbContext)
        {
            if (!dbContext.Users.Any(u => u.UserName == "jankowskij@ocenapracownikow.pl"))
            {
                var user = new AppUser
                {
                    UserName = "jankowskij@ocenapracownikow.pl",
                    NormalizedUserName = "jankowskij@ocenapracownikow.pl",
                    Email = "jankowskij@ocenapracownikow.pl",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    FirstName = "Jan",
                    LastName = "Jankowski",
                    Photo = "",
                    Information = "Profesor z wieloletnim doświadczeniem"
                };
                var password = new PasswordHasher<AppUser>();
                var hashed = password.HashPassword(user, "Ocena1234!");
                user.PasswordHash = hashed;

                var userStore = new UserStore<AppUser>(dbContext);
                userStore.CreateAsync(user).Wait();
                userStore.AddToRoleAsync(user, "pracownik").Wait();

                dbContext.SaveChanges();
            }

            if (!dbContext.Users.Any(u => u.UserName == "admin@ocenapracownikow.pl"))
            {
                var user = new AppUser
                {
                    UserName = "admin@ocenapracownikow.pl",
                    NormalizedUserName = "admin@ocenapracownikow.pl",
                    Email = "admin@ocenapracownikow.pl",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Photo = "",
                    Information = "Konto administracyjne"
                };
                var password = new PasswordHasher<AppUser>();
                var hashed = password.HashPassword(user, "Ocena1234!");
                user.PasswordHash = hashed;

                var userStore = new UserStore<AppUser>(dbContext);
                userStore.CreateAsync(user).Wait();
                userStore.AddToRoleAsync(user, "admin").Wait();
                dbContext.SaveChanges();
            }
        } // koniec użytkowników
    }
    
}
