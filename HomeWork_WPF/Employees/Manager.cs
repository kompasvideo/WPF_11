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
                return MainWindow.GetDepartment(DepartmentId);
                return 0;
            }
        }
        public Manager(string firstName, string lastName, int age, uint departmentId, string job = "Руководитель") : 
            base(firstName, lastName, age, departmentId, job)
        {
            EEmployee = EnEmployee.Manager;
        }
    }
}
