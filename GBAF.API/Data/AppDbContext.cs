using GBAF.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace GBAF.API.Data;

public class AppDbContext : IdentityDbContext<User>
{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
                base.OnModelCreating(builder);
                seedDefaultUser(builder);
        }
        private static void seedDefaultUser(ModelBuilder builder)
        {
                #region Populate Roles - Perfis de Usuário
                List<IdentityRole> roles = new()
        {
            new IdentityRole() {
               Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
               Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
               Name = "Usuário",
               NormalizedName = "USUÁRIO"
            },
        };
                builder.Entity<IdentityRole>().HasData(roles);
                #endregion

                #region Populate Usuário
                List<User> usuarios = new() {
            new User(){
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Email = "felipebotura7@gmail.com",
                NormalizedEmail = "felipebotura7@GMAIL.COM",
                UserName = "felipebotura",
                NormalizedUserName = "FELIPEBOTURA",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Name = "José Antonio Gallo Junior"
            }
        };
                foreach (var user in usuarios)
                {
                        PasswordHasher<IdentityUser> pass = new();
                        user.PasswordHash = pass.HashPassword(user, "123456");
                }
                builder.Entity<User>().HasData(usuarios);
                #endregion

                #region Populate UserRole - Usuário com Perfil
                List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id
            }
        };
                builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
                #endregion

        }
}
