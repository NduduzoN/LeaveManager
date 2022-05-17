using LeaveManagerMVC.Data;
using LeaveManagerMVC.Model;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagerMVC.Repository
{
    public class LeaveBalanceRepository : IRepository<LeaveBalance, int>
    {
        private readonly ApplicationDbContext leaveBalanceRepo;

        public LeaveBalanceRepository(ApplicationDbContext leaveBalanceRepo) => this.leaveBalanceRepo = leaveBalanceRepo;

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LeaveBalance>> Get()
        {
            return await leaveBalanceRepo.LeaveBalances.ToListAsync();
        }

        public async Task<LeaveBalance> Get(int id)
        {
            return await leaveBalanceRepo.LeaveBalances.FirstOrDefaultAsync(e => e.Id == id);
        }

        public Task<LeaveBalance> Insert(LeaveBalance entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(LeaveBalance entity)
        {
            throw new NotImplementedException();
        }
    }
}
