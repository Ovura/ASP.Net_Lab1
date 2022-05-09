using System;
using System.ComponentModel.DataAnnotations;

namespace Net21_ASP_Lab1.Models
{
    public class HolidayCheck
    {
      
        [Key]
        public int HolidayCheckID { get; set; }
        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }

        public string HolidayType { get; set; }
        public Holiday Holiday { get; set; }

    }
}
