﻿using Microsoft.EntityFrameworkCore;
using TaskMangementSystem.Models;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
