using System;

namespace Com.MyCompany.Oop.Labor2
{
    public class Employee : Person
    {
        public int EmployeeNumber { get; private set; }
        public int Salary { get; private set; }

        public Employee(string name, string cnp, DateTime birthDate, string role, int salary, int employeeNumber)
            : base(name, cnp, birthDate, role)
        {
            SetEmployeeNumber(employeeNumber);
            SetSalary(salary);
        }

        public void SetEmployeeNumber(int employeeNumber)
        {
            if (employeeNumber <= 0)
                throw new ArgumentException("Az employee szam nem lehet 0");
            EmployeeNumber = employeeNumber;
        }

        public void SetSalary(int salary)
        {
            if (salary <= 0)
                throw new ArgumentException("A salary nem lehet 0");
            Salary = salary;
        }
    }
}