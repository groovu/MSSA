using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepoTutorial
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private List<Employee> empList;
        public List<Employee> GetEmployees()
        {
            empList = new List<Employee>();
            empList.Add(new Employee() { Id = 123, Name = "Alice", Address = "404 Blank St" });
            return empList;
        }
        public void DeleteEmployee(int eid)
        {

        }
        public void AddEmployee(Employee obj)
        {
            empList.Add(obj);
        }
    }
}
