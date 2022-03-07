using ASP_Net_Core_Program.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ASP_Net_Core_Program.Database
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<MessageEntity> Messages { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
    }
}
