using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using _932.db;

namespace _932.Functions
{
    public class Registration
    {
        public static ObservableCollection<Employee> employees { get; set; }
        
        public static void RegistrationSotr(string surname, string name, string lastname, string phone, string password)
        {
            Employee newEmployee = new Employee();

            newEmployee.Lastname = lastname;
            newEmployee.Name = name;
            newEmployee.Surname = surname;
            newEmployee.Phone = phone;
            newEmployee.Password = password;
            newEmployee.id_role= 1;
            newEmployee.Salary = 20;

            DB_Class.connection.Employee.Add(newEmployee);
            DB_Class.connection.SaveChanges();
        }
    }
}
