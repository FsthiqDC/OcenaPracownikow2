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

            if (!dbContext.Roles.Any(r => r.Name == "author"))
            {
                roleStore.CreateAsync(new IdentityRole
                {
                    Name = "author",
                    NormalizedName = "author"
                }).Wait();
            }
        }  // koniec ról

        //zakładanie kont uzytkowników w apliakcji, o ile nie istnieją
        private static void SeedUsers(ApplicationDbContext dbContext)
        {
            if (!dbContext.Users.Any(u => u.UserName == "autor1@portal.pl"))
            {
                var user = new AppUser
                {
                    UserName = "autor1@portal.pl",
                    NormalizedUserName = "autor1@portal.pl",
                    Email = "autor1@portal.pl",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    FirstName = "Piotr",
                    LastName = "Pisarski",
                    Photo = "autor1.jpg",
                    Information = "Wszechstronny programista aplikacji sieciowych i internetowych. W portfolio ma kilka ciekawych projektów zrealizowanych dla firm z branży finansowej. Współpracuje z innowacyjnymi startupami."
                };
                var password = new PasswordHasher<AppUser>();
                var hashed = password.HashPassword(user, "Portalik1!");
                user.PasswordHash = hashed;

                var userStore = new UserStore<AppUser>(dbContext);
                userStore.CreateAsync(user).Wait();
                userStore.AddToRoleAsync(user, "author").Wait();

                dbContext.SaveChanges();
            }

            if (!dbContext.Users.Any(u => u.UserName == "autor2@portal.pl"))
            {
                var user = new AppUser
                {
                    UserName = "autor2@portal.pl",
                    NormalizedUserName = "autor2@portal.pl",
                    Email = "autor2@portal.pl",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    FirstName = "Anna",
                    LastName = "Autorska",
                    Photo = "autor2.jpg",
                    Information = "Doświadczona programistka i projektantka stron internetowych oraz uznana blogierka. Specjalizuje się w HTML5, CSS3, JavaScript, jQuery i Bootstrap. Obecnie pracuje nad nowymi rozwiązaniami dla graczy."
                };
                var password = new PasswordHasher<AppUser>();
                var hashed = password.HashPassword(user, "Portalik1!");
                user.PasswordHash = hashed;

                var userStore = new UserStore<AppUser>(dbContext);
                userStore.CreateAsync(user).Wait();
                userStore.AddToRoleAsync(user, "author").Wait();
                dbContext.SaveChanges();
            }

            if (!dbContext.Users.Any(u => u.UserName == "admin@portal.pl"))
            {
                var user = new AppUser
                {
                    UserName = "admin@portal.pl",
                    NormalizedUserName = "admin@portal.pl",
                    Email = "admin@portal.pl",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    FirstName = "Ewa",
                    LastName = "Ważna",
                    Photo = "woman.png",
                    Information = ""
                };
                var password = new PasswordHasher<AppUser>();
                var hashed = password.HashPassword(user, "Portalik1!");
                user.PasswordHash = hashed;

                var userStore = new UserStore<AppUser>(dbContext);
                userStore.CreateAsync(user).Wait();
                userStore.AddToRoleAsync(user, "admin").Wait();
                dbContext.SaveChanges();
            }
        } // koniec użytkowników
    }
    
}
