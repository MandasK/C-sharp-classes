using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        public DateTime DateFounded { get; }
        public string CompanyName { get; }
        public List<Employee> Employees { get; set; }
        public Company(string name, DateTime founded)
        {
            CompanyName = name;
            DateFounded = founded;
            Employees = new List<Employee>();
        }
        public void ListEmployees()
        {
            Console.WriteLine($"{CompanyName}");
            Console.WriteLine($"Founded: {DateFounded}");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, Title: {employee.Title}, StartDate: {employee.StartDate}");
            }
        }
    }
}