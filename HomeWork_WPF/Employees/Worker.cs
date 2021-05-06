using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_WPF.Employees
{
    class Worker :Employee
    {
        public Worker(string firstName, string lastName, int age, int departmentId, string job = "Рабочий") :
            base(firstName, lastName, age, departmentId, job)
        {
        }
        public override int Salary
        {
            get
            {
                return 12;
            }
        }
    }
}
