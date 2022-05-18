using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Laba1
{
    class AppContext : DbContext
    {
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Accumulate> Accumulates { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Installement> Installements { get; set; }
        public DbSet<BillsNSalary> BillsNSalaries { get; set; }
        public DbSet<CompanyTransfer> CompanyTransfer { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public AppContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = database.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>().HasData(
                new Bank[]
                {
                    new Bank
                    {
                        Id = 1,
                        BID = "053501",
                        Name = "first bank",
                        OverPaymentPercent = 6.6,
                        AccumPercent = 4.8,
                        TotalMoney = 0,
                        Clients = new List<Client>(),
                        ClientAccum = new List<Accumulate>(),
                    },
                    new Bank
                    {
                        Id = 2,
                        BID = "053506",
                        Name = "second bank",
                        OverPaymentPercent = 8.9,
                        AccumPercent = 3.9,
                        TotalMoney = 0,
                        Clients = new List<Client>(),
                        ClientAccum = new List<Accumulate>(),
                    }
                });
        }

    }
}
