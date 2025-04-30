using WebApplication37.Models;

namespace WebApplication37.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();

        void AddEmployee(Employee  obj);    
    }
}
