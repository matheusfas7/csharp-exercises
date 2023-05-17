using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) 
        { 
            Name = name;
            Salary = salary;
            Id = id;
        }
        public void increaseSalary(double percentage)
        {
            Salary = Salary + Salary * (percentage / 100);
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary;
        }
    }
}
