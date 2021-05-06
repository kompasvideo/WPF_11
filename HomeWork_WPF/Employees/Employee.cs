using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_WPF.Employees
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual int Salary { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public string Job { get; set; }

        public Employee(string firstName, string lastName, int age, int departmentId, string job)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DepartmentId = departmentId;
            Job = job;
        }
        public override string ToString()
        {
            return string.Format($"{LastName} {FirstName}"); 
        }
    }
}
