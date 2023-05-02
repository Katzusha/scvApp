using Microsoft.EntityFrameworkCore;
using scvApp.dbcontext;
using scvApp.Models;

namespace scvApp.Services
{
    public interface ISchoolSubmitService
    {
        Task AddNewSchoolSubmit(SchoolSubmit schoolsubmit);

        Task<List<SchoolSubmit>> GetAllSchoolSubmits();

        Task UpdateSchoolSubmit(SchoolSubmit schoolsubmit);

        Task DeleteSchoolSubmit(SchoolSubmit schoolsubmit);
    }

    public class SchoolSubmitService : ISchoolSubmitService
    {
        public async Task AddNewSchoolSubmit(SchoolSubmit schoolsubmit)
        {
            using (var context = new AppDbContext())
            {
                await context.SchoolSubmits.AddAsync(schoolsubmit);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<SchoolSubmit>> GetAllSchoolSubmits()
        {
            using (var context = new AppDbContext())
            {
                return await context.SchoolSubmits.ToListAsync();
            }
        }

        public async Task UpdateSchoolSubmit(SchoolSubmit schoolsubmit)
        {
            using (var context = new AppDbContext())
            {
                context.SchoolSubmits.Update(schoolsubmit);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteSchoolSubmit(SchoolSubmit schoolsubmit)
        {
            using (var context = new AppDbContext())
            {
                var oldschoolsubmit = await context.SchoolSubmits.FindAsync(schoolsubmit.Id);
                if (oldschoolsubmit != null)
                {
                    context.SchoolSubmits.Remove(oldschoolsubmit);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
