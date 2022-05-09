using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Net21_ASP_Lab1.Models
{
    public class Holiday
    {
        [Key]
        public int HolidayID { get; set; }

        [Required]
        public string HolidayType { get; set; }

        public string MaxDuration { get; set; }

        public ICollection<HolidayCheck> HolidayChecks { get; set; }


    }
}
