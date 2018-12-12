using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCClassDemo.Models
{
    public class EmployeeDB : IEmployeeDB
    {
        List<Employee> empDb = new List<Employee>();

        public void AddEmployee(Employee emp)
        {
            empDb.Add(emp);
        }

        public void DeleteEmployee(int id)
        {
            foreach(Employee emp in empDb)
            {
                if(emp.id == id)
                {
                    empDb.Remove(emp);
                    return;
                }
                
            }
        }

        public List<Employee> GetEmployees()
        {
            return empDb;
        }

        public void UpdateEmployee(Employee employee)
        {
            var found = empDb.Find((e) => e.id == employee.id);
            found.name = employee.name;
            found.city = employee.city;
            found.salary = employee.salary;
        }
    }
}