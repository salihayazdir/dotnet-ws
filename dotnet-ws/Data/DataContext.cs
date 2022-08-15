using System;
using Microsoft.EntityFrameworkCore;

namespace dotnet_ws.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Atm> Atms { get; set; }
    }
}

