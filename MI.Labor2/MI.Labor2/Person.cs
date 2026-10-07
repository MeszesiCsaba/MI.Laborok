using System;
using System.Text.RegularExpressions;

namespace Com.MyCompany.Oop.Labor2
{
    public class Person
    {
        public string Name { get; private set; }
        public string CNP { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Role { get; private set; }

        public Person(string name, string cnp, DateTime birthDate, string role)
        {
            Name = name ?? throw new ArgumentException("A nev nem lehet ures.");
            SetName(name);
            SetCnp(cnp);
            SetBirthDate(birthDate);
            SetRole(role);
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("A nev nem lehet ures.");
            Name = name;
        }

        public void SetCnp(string cnp)
        {
            if (cnp == null || !Regex.IsMatch(cnp, @"^\d{13}$"))
                throw new ArgumentException("Hibas CNP.");
            CNP = cnp;
        }

        public void SetBirthDate(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public void SetRole(string role)
        {
            Role = role;
        }
    }
}