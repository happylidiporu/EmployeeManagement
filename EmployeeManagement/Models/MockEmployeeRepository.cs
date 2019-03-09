using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Happy", Departement = "IT", Email = "happy@lidiporu.com"},
                new Employee() {Id = 1, Name = "Mary", Departement = "HR", Email = "mary@gmail.com"},
                new Employee() {Id = 3, Name = "John", Departement = "IT", Email = "john@yahoo.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
