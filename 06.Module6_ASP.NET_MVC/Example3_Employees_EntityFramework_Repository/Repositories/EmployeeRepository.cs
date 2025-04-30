using WebApplication37.Models;

namespace WebApplication37.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public void AddEmployee(Employee obj)
        {
            _context.Employees.Add(obj);
            _context.SaveChanges();
        }

    }
}
