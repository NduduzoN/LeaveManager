using LeaveManagerMVC.Data;
using LeaveManagerMVC.Model;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagerMVC.Repository
{
    public class EmployeeRepository : IRepository<Employee, int>
    {
        private readonly ApplicationDbContext employeeRepo;

        public EmployeeRepository(ApplicationDbContext employeeRepo) => this.employeeRepo = employeeRepo;
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> Get()
        {
            return await employeeRepo.Employees.ToListAsync();
        }

        public async Task<Employee> Get(int id)
        {
            return await employeeRepo.Employees.FirstOrDefaultAsync(e => e.EmpId == id);
        }

        public Task<Employee> Insert(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
