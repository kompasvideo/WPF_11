using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HomeWork_WPF.Employees;

namespace HomeWork_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// Организация
        static Repository repository;
        // выбранный TreeViewItem 
        Department select;
        static int salary = 0;
        System.ComponentModel.ICollectionView myView;
        public MainWindow()
        {
            InitializeComponent();
            repository = new Repository();
            select = repository.Departments[0];
            treeView.ItemsSource = repository.Departments;
            myView = CollectionViewSource.GetDefaultView(repository.Employees);
            WPFDataGrid.ItemsSource = myView;
            FIO.DataContext = new SelectProvider(select);
            Salary.DataContext = new SelectProvider(select);
        }

        private bool myFilter(object obj)
        {
            if (select.DepartmentId == 0) return true;
            else
            {
                var e = obj as Employee;
                if (e != null)
                {
                    if (select.DepartmentId == e.DepartmentId) return true;
                }
                return false;
            }
        }
        
        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            select = (Department)e.NewValue;
            FIO.DataContext = new SelectProvider(select);
            Salary.DataContext = new SelectProvider(select);
            myView.Filter = new Predicate<object>(myFilter);
        }
        public static void SetSalary(uint p_depId)
        {
            foreach (var emp in repository.Employees)
            {
                if (emp.DepartmentId == p_depId)
                {
                    if (emp.GetType() == typeof(Worker))
                    {
                        salary += emp.Salary * 8 * 23;
                    }
                    if (emp.GetType() == typeof(Intern))
                    {
                        salary += emp.Salary;
                    }
                }
            }           
        }

        public static int GetDepartment(uint p_depId)
        {
            salary = 0;
            foreach (var dep in repository.Departments)
            {
                if (dep.DepartmentId == p_depId)
                    SearchDepartment(p_depId, dep.Departments, true);
                else
                    SearchDepartment(p_depId, dep.Departments,false);
            }
            return salary;
        }
        private static void SearchDepartment(uint p_depId, ObservableCollection<Department> departments,bool child)
        {            
            foreach (var dep in departments)
            {
                if (dep.DepartmentId == p_depId)
                {
                    SetSalary(p_depId);
                    if (dep.Departments != null)
                    {
                        foreach (var depR in dep.Departments)
                        {
                            SearchDepartment(p_depId, dep.Departments, true);
                        }
                    }
                }
                else
                {
                    if (child)
                    {
                        SetSalary(p_depId);
                    }
                    if (dep.Departments != null)
                    {
                        SearchDepartment(p_depId, dep.Departments, child);
                    }
                }
            }
        }
    }
}
