using HomeTaskDelgate;
using System.Collections.Generic;
using System.Linq;

public class EmployeeHelper
{
    public static double CalculateAverageSalary(List<Employee> employees, int minAge, int maxAge)
    {
        var selectedEmployees = employees.Where(e => e.Age >= minAge && e.Age <= maxAge);
        double averageSalary = selectedEmployees.Select(e => e.Salary).DefaultIfEmpty(0).Average();
        return averageSalary;
    }
}

