using System;
using System.Collections.Generic;

namespace classes
{
  public class Company
  {
    public DateTime DateFounded { get; }
    public string CompanyName { get; }
    public List<Employee> employees = new List<Employee>();
    //methods
    public void addEmployees(Employee employee)
    {
      employees.Add(employee);
    }

    public void listEmployees(Company company)
    {
      foreach (Employee employee in company.employees)
      {
        Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {company.CompanyName} as a {employee.Title} since {employee.StartTime}");
      }
    }

    public Company(string name, DateTime datefounded)
    {
      CompanyName = name;
      DateFounded = datefounded;
    }
  }
}
