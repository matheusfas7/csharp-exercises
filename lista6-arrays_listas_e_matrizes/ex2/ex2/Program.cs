// See https://aka.ms/new-console-template for more information
using ex2;
using System.Globalization;
using System.Collections.Generic;

List<Employee> employees = new List<Employee>();

Console.Write("How many employees will be registered? "); 
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Employee #{i}:" );
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    employees.Add(new Employee(id, name, salary));
}

Console.WriteLine();
Console.Write("Enter the employee id that will have salary increase: ");
int serachId = int.Parse(Console.ReadLine());

Employee emp = employees.Find(x => x.Id == serachId);
if (emp != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.increaseSalary(percentage);
} else
{
    Console.WriteLine("This id doesn't exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
}
