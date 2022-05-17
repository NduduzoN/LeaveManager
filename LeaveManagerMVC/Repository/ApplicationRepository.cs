using LeaveManagerMVC.Data;
using System.Data.SqlClient;
using LeaveManagerMVC.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


namespace LeaveManagerMVC.Repository
{
    public class ApplicationRepository : IRepository<Application, int>
    {
        private readonly ApplicationDbContext applicationRepo;

        public ApplicationRepository(ApplicationDbContext applicationRepo) => this.applicationRepo = applicationRepo;
        public async Task Delete(int id)
        {
            var application = await applicationRepo.Applications.FindAsync(id);
            applicationRepo.Applications.Remove(application);
            await applicationRepo.SaveChangesAsync();
        }

        public async Task<IEnumerable<Application>> Get()
        {
            return await applicationRepo.Applications.ToListAsync(); 
        }

        public async Task<Application> Get(int id)
        {
            return await applicationRepo.Applications.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Application> Insert([Bind()] Application entity)
        {
            if (ModelState.IsValid)
            {
                applicationRepo.Add(entity);
                await applicationRepo.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entity);
        }

        public Task Update(Application entity)
        {
            throw new NotImplementedException();
        }
    }
}
