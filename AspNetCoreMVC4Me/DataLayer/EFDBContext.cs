using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class EFDBContext:DbContext
    {
        public DbSet<Directory> Directory { get; set; }
        public DbSet<Material> Materials { get; set; }
        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options) { }
    }
    public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;DataBase=LoftSoftAspNetCoreMVC; Trusted_Connection=true; MultipleAvtiveResultSets=true", b => b.MigrationsAssembly("DataLayer"));

            return new EFDBContext(optionBuilder.Options);
        }
    }
}
