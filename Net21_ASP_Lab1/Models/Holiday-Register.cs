using Microsoft.EntityFrameworkCore;

namespace Net21_ASP_Lab1.Models
{
    public class Holiday_Register : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Holiday> Holidays { get; set; }
       
        public DbSet<HolidayCheck> HolidayChecks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =LAPTOP-JHQVGT2H\SQLEXPRESS; Initial Catalog = Holiday_Register; Integrated Security = True;");
        }
    }
}
