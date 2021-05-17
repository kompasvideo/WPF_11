using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_WPF.Employees
{
    [Serializable]
    public class Worker :Employee
    {
        public Worker(string firstName, string lastName, int age, uint departmentId, string job = "Рабочий") :
            base(firstName, lastName, age, departmentId, job)
        {
        }
        public Worker()
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
