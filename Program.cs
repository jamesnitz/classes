using System;

namespace classes
{
  class Program
  {
    static void Main(string[] args)
    {
      Employee employee1 = new Employee()
      {
        FirstName = "James",
        LastName = "Nitz",
        Title = "pope",
        StartTime = new DateTime(2020, 03, 10)
      };
      Employee employee2 = new Employee()
      {
        FirstName = "Kev",
        LastName = "Kevinson",
        Title = "Fashionista",
        StartTime = new DateTime(2020, 03, 10)
      };
      Employee employee3 = new Employee()
      {
        FirstName = "My",
        LastName = "Dad",
        Title = "Father",
        StartTime = new DateTime(2020, 03, 10)
      };

      Company bruh = new Company("bruh inc", new DateTime(2020 / 03 / 10));
      bruh.addEmployees(employee1);
      bruh.addEmployees(employee2);
      bruh.addEmployees(employee3);
      bruh.listEmployees(bruh);

    }
  }
}
