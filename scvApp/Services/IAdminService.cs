using Microsoft.EntityFrameworkCore;
using scvApp.dbcontext;
using scvApp.Models;

namespace scvApp.Services
{
    public interface IAdminService
    {
        Task AddNewAdmin(Admin admin);

        Task<List<Admin>> GetAllAdmins();
    }

    public class AdminService : IAdminService
    {
        public async Task AddNewAdmin(Admin admin)
        {
            using (var context = new AppDbContext())
            {
                await context.Admins.AddAsync(admin);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Admin>> GetAllAdmins()
        {
            using (var context = new AppDbContext())
            {
                return await context.Admins.ToListAsync();
            }
        }
    }
}
