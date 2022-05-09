using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Net21_ASP_Lab1.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Title { get; set; }

        public ICollection<HolidayCheck> HolidayChecks { get; set; }

    }
}
