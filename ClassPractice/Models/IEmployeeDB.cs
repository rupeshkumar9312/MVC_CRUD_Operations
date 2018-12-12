using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCClassDemo.Models
{
    interface IEmployeeDB
    { 
        void AddEmployee(Employee emp);
        List<Employee> GetEmployees();
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee employee);
    }
}
