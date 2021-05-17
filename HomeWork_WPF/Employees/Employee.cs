using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_WPF
{
    [Serializable]
    public abstract class Employee : INotifyPropertyChanged
    {
        [NonSerialized]
        string firstName;
        [NonSerialized]
        string lastName;
        [NonSerialized]
        int salary;
        [NonSerialized]
        int age;
        [NonSerialized]
        uint departmentId;
        [NonSerialized]
        string job;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public virtual int Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                OnPropertyChanged("Salary");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
        public uint DepartmentId
        {
            get { return departmentId; }
            set
            {
                departmentId = value;
                OnPropertyChanged("DepartmentId");
            }
        }
        public string Job
        {
            get { return job; }
            set
            {
                job = value;
                OnPropertyChanged("Job");
            }
        }

        public Employee(string firstName, string lastName, int age, uint departmentId, string job)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DepartmentId = departmentId;
            Job = job;
        }
        public Employee()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public override string ToString()
        {
            return string.Format($"{LastName} {FirstName}");
        }
    }
}
