using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceManagementSystem.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace AttendanceManagementSystem.Infrastructure;

public class TimeSheetDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Log> Logs { get; set; }
    public DbSet<UserAccount> UserAccounts { get; set; }
    public String DbPath { get;}
    public TimeSheetDbContext()
    {
        var folder = Environment.SpecialFolder.MyDocuments;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "TimeSheetDB.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source = {DbPath}");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //set the primary key
        modelBuilder.Entity<UserAccount>().HasKey(p=>p.UserAccountID);
        //set the auto primary key
        modelBuilder.Entity<UserAccount>().Property(f => f.UserAccountID).ValueGeneratedOnAdd();
        //Configure one to relation
        modelBuilder.Entity<Employee>()
            .HasOne<UserAccount>(u=> u.UserAccount)
            .WithOne(e=>e.Employee)
            .HasForeignKey<UserAccount>(u=>u.UserAccounctOfEmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
        //Configure one to many relation
        modelBuilder.Entity<Employee>()
            .HasMany<Log>(l => l.Logs)
            .WithOne(e => e.Employee)
            .HasForeignKey(l => l.CurrentEmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
