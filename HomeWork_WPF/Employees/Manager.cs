using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_WPF.Employees
{
    class Manager:Employee
    {
        public override int Salary 
        { 
            get
            {
                return 1300;
            }
        }
        public Manager(string firstName, string lastName, int age, int departmentId, string job = "Руководитель") : 
            base(firstName, lastName, age, departmentId, job)
        {           
        }
    }
}
