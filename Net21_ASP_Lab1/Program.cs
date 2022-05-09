using Microsoft.EntityFrameworkCore;
using Net21_ASP_Lab1.Models;
using System;
using System.Linq;

namespace Net21_ASP_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seed Data

            using Holiday_Register context = new Holiday_Register();

            //Employee E1 = new Employee()
            //{
            //    FirstName = "John",
            //    LastName = "Wayne",
            //    Title = "Manager"
            //};

            //Employee E2 = new Employee()
            //{
            //    FirstName = "Peter",
            //    LastName = "Petersson",
            //    Title = "Accountant"
            //};

            //Employee E3 = new Employee()
            //{
            //    FirstName = "Tomas",
            //    LastName = "Tomasson",
            //    Title = "Administrator"
            //};

            //Holiday H1 = new Holiday();
            //{
            //    H1.HolidayType = "AnnualLeave";
            //    H1.MaxDuration = "35 Days";
            //}

            //Holiday H2 = new Holiday();
            //{
            //    H2.HolidayType = "SickLeave";
            //    H2.MaxDuration = "180 Days";
            //}

            //Holiday H3 = new Holiday();
            //{
            //    H3.HolidayType = "ParentalLeave";
            //    H3.MaxDuration = "412 Days";
            //}


            //HolidayCheck HC1 = new HolidayCheck()
            //{
            //    StartDate = DateTime.Now,
            //    EndDate = DateTime.Parse("2022-06-01"),
            //    EmployeeID = 3,
            //    HolidayType = "ParentalLeave"


            //};

            //HolidayCheck HC2 = new HolidayCheck()
            //{
            //    StartDate = DateTime.Now,
            //    EndDate = DateTime.Parse("2022-07-25"),
            //    EmployeeID = 2,
            //    HolidayType = "AnnualLeave"


            //};

            //HolidayCheck HC3 = new HolidayCheck()
            //{
            //    StartDate = DateTime.Now,
            //    EndDate = DateTime.Parse("2022-08-30"),
            //    EmployeeID = 1,
            //    HolidayType = "SickLeave"

            //};


            //context.Add(E1);
            //context.Add(E2);
            //context.Add(E3);
            //context.Add(H1);
            //context.Add(H2);
            //context.Add(H3);
            //context.Add(HC1);
            //context.Add(HC2);
            //context.Add(HC3);



            //context.SaveChanges();



            //Read Data from DB

            //Viewing a specific person's Details


            var employees = context.HolidayChecks
                .Where(p => p.Employee.LastName == "Tomasson" && p.HolidayType != null)
                .OrderBy(p => p.Employee.LastName);

            foreach (var emp in employees)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}");
                Console.WriteLine($"Holiday Type: {emp.HolidayType}");
                Console.WriteLine(new string('-', (20)));
            }


            Console.ReadKey();
        }
    }
}
