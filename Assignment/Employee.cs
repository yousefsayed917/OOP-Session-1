using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    enum SecurityLevel
    {
        Guest, Developer, Secretary, DBA
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        SecurityLevel securitylevel { get; set; }
        public double salary { get; set; }
        HiringDate HireDate;
        public string? gender;
        public void SetGender(string gender)
        {
            do
            {
                Console.WriteLine("Gender must be M or F");
            } while (gender != "M" || gender != "F");

            this.gender = gender;
        }
        public string GetGender()
        {
            return gender!;
        }
        public Employee(int id, string? name, SecurityLevel securitylevel, HiringDate hiredate, double salary, string gender)
        {
            Id = id;
            Name = name;
            this.securitylevel = securitylevel;
            this.HireDate = hiredate;
            this.salary = salary;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"Salary = {string.Format("{0:C}", salary)}";
        }

    }

}
