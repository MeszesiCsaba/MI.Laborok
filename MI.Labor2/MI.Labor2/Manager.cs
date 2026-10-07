using System;

namespace Com.MyCompany.Oop.Labor2
{
    public class Manager : Person
    {
        public int Salary { get; private set; }

        public Manager(string name, string cnp, DateTime birthDate, string role, int salary)
            : base(name, cnp, birthDate, role)
        {
            SetSalary(salary);
        }

        public void SetSalary(int salary)
        {
            if (salary <= 0)
                throw new ArgumentException("A fizetes nem lehet 0");
            Salary = salary;
        }
    }
}