using ocenaocena.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ocenaocena.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
    }
        public DbSet<AppUser>? AppUsers { get; set; }
        public DbSet<AktywnoscBadawcza>? AktywnoscBadawcza { get; set; }
        public DbSet<MonografiaNaukowa>? MonografieNaukowe { get; set; }
        public DbSet<ArtykulNaukowy>? ArtykulyNaukowe { get; set; }
        public DbSet<EkspertyzaNaukowa>? RealizacjaZleconychEkspertyz { get; set; }
        public DbSet<KonferencjaNaukowa>? CzynnyUdzialWKonferencjach { get; set; }
        public DbSet<DzialalnoscOrganizacyjna>? DzialalnoscWOrganizacjachNaukowych { get; set; }
        public DbSet<PozostalaDzialalnoscNaukowa>? PozostaleDzialalnosciNaukowe { get; set; }
        public DbSet<NagrodaWyroznienie>? NagrodyWyroznienia { get; set; }
        public DbSet<PozostaleFormyAktywnosci>? PozostaleFormyAktywnosci { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}