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
        Title = "pope"
      };
      Employee employee2 = new Employee()
      {
        FirstName = "Kev",
        LastName = "Kevinson",
        Title = "Fashionista"
      };
      Employee employee3 = new Employee()
      {
        FirstName = "My",
        LastName = "Dad",
        Title = "Father"
      };

      Company bruh = new Company("bruh inc", DateTime.Now);
      bruh.addEmployees(employee1);
      bruh.addEmployees(employee2);
      bruh.addEmployees(employee3);

      bruh.listEmployees(bruh);

    }
  }
}
