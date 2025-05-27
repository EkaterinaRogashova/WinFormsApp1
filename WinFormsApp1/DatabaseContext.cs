using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Analiz> Analyzes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Analiz>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.Analyzes)
                .HasForeignKey(a => a.PatientId);
        }
    }
}
