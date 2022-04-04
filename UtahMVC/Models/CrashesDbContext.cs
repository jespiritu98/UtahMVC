using System;
using Microsoft.EntityFrameworkCore;


namespace UtahMVC.Models
{
    public class CrashesDbContext : DbContext
    {
        public CrashesDbContext(DbContextOptions<CrashesDbContext> options) : base(options)
        {

        }

        public DbSet<Crash> Crashes { get; set; }
    }
}
