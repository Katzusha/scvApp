using Microsoft.EntityFrameworkCore;
using scvApp.dbcontext;
using scvApp.Models;

namespace scvApp.Services
{
    public interface IAdminService
    {
        Task AddNewAdmin(Admin admin);

        Task<List<Admin>> GetAllAdmins();

        Task UpdateAdmin(Admin admin);

        Task DeleteAdmin(Admin admin);
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

        public async Task UpdateAdmin(Admin admin)
        {
            using (var context = new AppDbContext())
            {
                context.Admins.Update(admin);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAdmin(Admin admin)
        {
            using (var context = new AppDbContext())
            {
                var oldAdmin = await context.Admins.FindAsync(admin.Id);
                if (oldAdmin != null)
                {
                    context.Admins.Remove(oldAdmin);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
