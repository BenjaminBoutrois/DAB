using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAB.Webservice.Models;

namespace DAB.Webservice.Data
{
    public class DABWebserviceContext : DbContext
    {
        public DABWebserviceContext (DbContextOptions<DABWebserviceContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }

        // Seed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(a => a.AuthenticationTries)
                .HasDefaultValue(0);

            modelBuilder.Entity<Account>()
                .HasData(
                new Account
                {
                    Id = 1,
                    Number = "1234123412341234",
                    Pin = "1234",
                    Balance = 50d,
                    AuthenticationTries = 0
                },
                new Account
                {
                    Id = 2,
                    Number = "3456345634563456",
                    Pin = "3456",
                    Balance = 100d,
                    AuthenticationTries = 0
                },
                new Account
                {
                    Id = 3,
                    Number = "5678567856785678",
                    Pin = "5678",
                    Balance = 150d,
                    AuthenticationTries = 0
                },
                new Account
                {
                    Id = 4,
                    Number = "7890789078907890",
                    Pin = "7890789078907890",
                    Balance = 200d,
                    AuthenticationTries = 0
                },
                new Account
                {
                    Id = 5,
                    Number = "9012901290129012",
                    Pin = "9012",
                    Balance = 250d,
                    AuthenticationTries = 0
                });
        }
    }
}
