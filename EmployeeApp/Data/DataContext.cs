global using Microsoft.EntityFrameworkCore;
using EmployeeApp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-6VSET39; Database=EmployeeDB; User Id=sa; Password=tommya;Trusted_Connection=true; TrustServerCertificate = true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee[]
            {
                new Employee {Id = 1, FirstName = "Desh",LastName="Bandara",Gender="M",DateOfBirth=DateTime.Now,Address="Kandy",DepartmentId=1,BasicSalary=100000},
                new Employee {Id = 2, FirstName = "John",LastName="Kumara",Gender="F",DateOfBirth=DateTime.Now,Address="UK",DepartmentId=2,BasicSalary=200000},
                new Employee {Id = 3, FirstName = "Kuma",LastName="rai",Gender="M",DateOfBirth=DateTime.Now,Address="Kandy",DepartmentId=1,BasicSalary=500000},
                new Employee {Id = 4, FirstName = "Kamal",LastName="Petor",Gender="M",DateOfBirth=DateTime.Now,Address="UK",DepartmentId=3, BasicSalary = 1000000},

            });

            modelBuilder.Entity<Department>().HasData(new Department[]
           {
                new Department {Id = 1, Name = "IT" },
                new Department {Id = 2, Name = "HR" },
                new Department {Id = 3, Name = "Finance" },
                new Department {Id = 4, Name = "Audit" }

           });

            //modelBuilder.Entity<Employee>()
            //   .HasOne(e => e.Department)
            //   .WithMany(d => d.Employees)
            //   .HasForeignKey(e => e.DepartmentId);
        }
    }
}
