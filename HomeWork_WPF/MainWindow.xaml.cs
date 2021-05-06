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
        // Список отделов
        ObservableCollection<Department> departments;
        ObservableCollection<Employee> Employees { get; set; }

        // выбранный TreeViewItem 
        Department select;

        static int w_iterator;
        public MainWindow()
        {
            InitializeComponent();
            w_iterator = 0;
            departments = new ObservableCollection<Department>
            {
                new Department("ОАО 'Лучшие кодеры'", 0,
                    new ObservableCollection<Department>
                    {
                        new Department("Департамент_1", 1, new ObservableCollection<Department>
                        {
                            new Department("Департамент_11", 11, new ObservableCollection<Department>()),
                            new Department("Департамент_12", 12, new ObservableCollection<Department>())
                        }),
                        new Department("Департамент_2", 2, new ObservableCollection<Department>
                        {
                            new Department("Департамент_21", 21, new ObservableCollection<Department>()),
                            new Department("Департамент_22", 22, new ObservableCollection<Department>()),
                            new Department("Департамент_23", 23, new ObservableCollection<Department>()),
                            new Department("Департамент_24", 24, new ObservableCollection<Department>())
                        }),
                        new Department("Департамент_3", 3, new ObservableCollection<Department>
                        {
                            new Department("Департамент_31", 31, new ObservableCollection<Department>()),
                        }),
                        new Department("Департамент_4", 4, new ObservableCollection<Department>
                        {
                            new Department("Департамент_41", 41, new ObservableCollection<Department>()),
                            new Department("Департамент_42", 42, new ObservableCollection<Department>()),
                            new Department("Департамент_43", 43, new ObservableCollection<Department>()),
                            new Department("Департамент_44", 44, new ObservableCollection<Department>()),
                            new Department("Департамент_45", 45, new ObservableCollection<Department>()),
                            new Department("Департамент_46", 46, new ObservableCollection<Department>()),
                            new Department("Департамент_47", 47, new ObservableCollection<Department>()),
                            new Department("Департамент_48", 48, new ObservableCollection<Department>())
                        }),
                        new Department("Департамент_5", 5, new ObservableCollection<Department>
                        {
                            new Department("Департамент_51", 51, new ObservableCollection<Department>
                            {
                                new Department("Департамент_511", 511, new ObservableCollection<Department>
                                {
                                    new Department("Департамент_5111", 5111, new ObservableCollection<Department>
                                    {
                                        new Department("Департамент_51111", 51111, new ObservableCollection<Department>()),
                                        new Department("Департамент_51112", 51112, new ObservableCollection<Department>()),
                                        new Department("Департамент_51113", 51113, new ObservableCollection<Department>()),
                                        new Department("Департамент_51114", 51114, new ObservableCollection<Department>()),
                                    }),
                                    new Department("Департамент_5112", 5112, new ObservableCollection<Department>()),
                                    new Department("Департамент_5113", 5113, new ObservableCollection<Department>()),
                                }),
                                new Department("Департамент_512", 512, new ObservableCollection<Department>()),
                            }),
                            new Department("Департамент_52", 52, new ObservableCollection<Department>
                            {
                                new Department("Департамент_521", 521, new ObservableCollection<Department>()),
                                new Department("Департамент_522", 522, new ObservableCollection<Department>()),
                                new Department("Департамент_523", 523, new ObservableCollection<Department>())
                            }),
                            new Department("Департамент_53", 53, new ObservableCollection<Department>
                            {
                                new Department("Департамент_531", 531, new ObservableCollection<Department>())
                            }),
                            new Department("Департамент_54", 54, new ObservableCollection<Department>()),
                        })
                    }
                ),
            };
            Employees = new ObservableCollection<Employee>
            {
                new Manager("Имя_1","Фамилия_1", 40,0),
                new Manager("Имя_2","Фамилия_2", 39,1),
                new Manager("Имя_3","Фамилия_3", 38,11),
                new Manager("Имя_4","Фамилия_4", 37,12),
                new Manager("Имя_5","Фамилия_5", 36,2),
                new Manager("Имя_6","Фамилия_6", 35,21),
                new Manager("Имя_7","Фамилия_7", 36,22),
                new Manager("Имя_8","Фамилия_8", 37,23),
                new Manager("Имя_9","Фамилия_9", 38,24),
                new Manager("Имя_10","Фамилия_10", 39,3),
                new Manager("Имя_11","Фамилия_11", 40,31),
                new Manager("Имя_12","Фамилия_12", 39,4),
                new Manager("Имя_13","Фамилия_13", 40,41),
                new Manager("Имя_14","Фамилия_14", 40,42),
                new Manager("Имя_15","Фамилия_15", 40,43),
                new Manager("Имя_16","Фамилия_16", 40,44),
                new Manager("Имя_17","Фамилия_17", 40,45),
                new Manager("Имя_18","Фамилия_18", 40,46),
                new Manager("Имя_19","Фамилия_19", 40,47),
                new Manager("Имя_20","Фамилия_20", 40,48),
                new Manager("Имя_21","Фамилия_21", 40,5),
                new Manager("Имя_22","Фамилия_22", 40,51),
                new Manager("Имя_23","Фамилия_23", 40,511),
                new Manager("Имя_24","Фамилия_24", 40,5111),
                new Manager("Имя_25","Фамилия_25", 40,51111),
                new Manager("Имя_26","Фамилия_26", 40,51112),
                new Manager("Имя_27","Фамилия_27", 40,51113),
                new Manager("Имя_28","Фамилия_28", 40,51114),
                new Manager("Имя_29","Фамилия_29", 40,5112),
                new Manager("Имя_30","Фамилия_30", 40,5113),
                new Manager("Имя_31","Фамилия_31", 40,512),
                new Manager("Имя_32","Фамилия_32", 40,52),
                new Manager("Имя_33","Фамилия_33", 40,521),
                new Manager("Имя_34","Фамилия_34", 40,522),
                new Manager("Имя_35","Фамилия_35", 40,523),
                new Manager("Имя_36","Фамилия_36", 40,53),
                new Manager("Имя_37","Фамилия_37", 40,531),
                new Manager("Имя_38","Фамилия_38", 40,54),
                new Worker("Имя_39","Фамилия_39", 40,1),
                new Worker("Имя_40","Фамилия_40", 40,2),
                new Worker("Имя_41","Фамилия_41", 40,3),
                new Intern("Имя_42","Фамилия_42", 40,1),
            };
            select = departments[0];
            SaveManager(departments);
            treeView.ItemsSource = departments;
            WPFDataGrid.ItemsSource = Employees;
            FIO.DataContext = new SelectProvider(select);
            Salary.DataContext = new SelectProvider(select);
        }

        void SaveManager(ObservableCollection<Department> p_departments)
        {
            foreach (var dep in p_departments)
            {
                dep.manager = Employees[w_iterator++] as Manager;
                if (dep.Departments != null) SaveManager(dep.Departments);
            }
        }

        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            select = (Department)e.NewValue;
            FIO.DataContext = new SelectProvider(select);
            Salary.DataContext = new SelectProvider(select);
            //l_Workers.Clear();
            //foreach (var w in Workers)
            //{
            //    if (select.DepartmentId != 0)
            //    {
            //        if (w.DepartmentId == select.DepartmentId)
            //            l_Workers.Add(w);
            //    }
            //    else l_Workers.Add(w);
            //}
            //WPFDataGrid.ItemsSource = l_Workers;
        }
    }
}
