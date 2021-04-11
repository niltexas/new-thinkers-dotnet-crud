using System;
using DotNetCrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrud.Context
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> option) : base(option)
        {

        }


        public DbSet<Jogo> jogo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
