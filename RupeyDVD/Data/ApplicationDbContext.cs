﻿using RupeyDVD.Models;
using Microsoft.EntityFrameworkCore;

namespace RupeyDVD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<DVDCategory> DVDCategories { get; set; }
        public DbSet<LoanType> LoanTypes { get; set; }
        public DbSet<MembershipCategory> MembershipCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<DVDTitle> DVDTitles { get; set; }
        public DbSet<DVDCopy> DVDCopies { get; set; }
        public DbSet<Loan> Loans { get; set; }

    }
}
