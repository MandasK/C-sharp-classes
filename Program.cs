using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company DunderMifflin = new Company("Dunder Mifflin", new DateTime(2005, 03, 05));
            Employee JimHalpert = new Employee()
            {
                FirstName = "Jim",
                LastName = "Halpert",
                Title = "Junior Salesman",
                StartDate = new DateTime(2005, 03, 24)
            };
            Employee DwightSchrute = new Employee()
            {
                FirstName = "Dwight K.",
                LastName = "Schrute",
                Title = "Assistant to the Regional Manager",
                StartDate = new DateTime(1999, 01, 01)
            };
            Employee MichaelScott = new Employee()
            {
                FirstName = "Michael",
                LastName = "Scott",
                Title = "Regional Manager and Lover to Jan",
                StartDate = new DateTime(2005, 03, 24)
            };

            DunderMifflin.Employees.Add(JimHalpert);
            DunderMifflin.Employees.Add(DwightSchrute);
            DunderMifflin.Employees.Add(MichaelScott);

            DunderMifflin.ListEmployees();

        }
    }
}