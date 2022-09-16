﻿using EntroductionEF.Data.Configurations;
using EntroductionEF.Models;
using Microsoft.EntityFrameworkCore;

namespace EntroductionEF.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //Aplique a configuração para todas as classes concretas que estão implementando IEntityTypeConfiguration nesse assembly.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }


        public DbSet<Solicitation> Solicitations { get; set; }
    }
}
