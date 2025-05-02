using Consultation.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConsultationDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server " +
                "Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Program> Program { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<EnrolledCourse> EnrolledCourse { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<SchoolYear> SchoolYear { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
