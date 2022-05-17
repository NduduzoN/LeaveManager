using LeaveManagerMVC.Data;
using LeaveManagerMVC.Model;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagerMVC.Repository
{
    public class LeaveTypeRepository : IRepository<LeaveType, int>
    {
        private readonly ApplicationDbContext leaveTypeRepo;

        public LeaveTypeRepository(ApplicationDbContext leaveTypeRepo) => this.leaveTypeRepo = leaveTypeRepo;
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LeaveType>> Get()
        {
            return await leaveTypeRepo.LeaveTypes.ToListAsync();
        }

        public async Task<LeaveType> Get(int id)
        {
            return await leaveTypeRepo.LeaveTypes.FirstOrDefaultAsync(e => e.LeaveTypeId == id);
        }

        public Task<LeaveType> Insert(LeaveType entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(LeaveType entity)
        {
            throw new NotImplementedException();
        }
    }
}
