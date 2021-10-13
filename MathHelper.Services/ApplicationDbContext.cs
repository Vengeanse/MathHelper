using MathHelper.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace MathHelper.Services
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, UserRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<MathTask> Tasks { get; set; }

        public DbSet<ApplicationUser> AspNetUsers { get; set; }

        public DbSet<SolvedTask> SolvedTasks { get; set; }

        public DbSet<UserSettings> UsersSettings { get; set; }

    }
}
