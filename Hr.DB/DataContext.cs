﻿using Hr.BL.Entities;
using Hr.DB.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Hr.DB
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Settlement> Settlements { get; set; }
        public DbSet<BasePositionStaffEntity> BasePositionStaffEntities { get; set; }
        public DbSet<PositionsAndDepartments> PositionsAndDepartments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentsAndBranchesConfiguration());
            modelBuilder.ApplyConfiguration(new PositionsAndDepartmentsConfiguration());
        }            
    }
}
