using Microsoft.EntityFrameworkCore;
using scvApp.dbcontext;
using scvApp.Models;

namespace scvApp.Services
{
    public interface ISchoolService
    {
        Task AddNewSchool(School school);
        
        Task<List<School>> GetAllSchools();
    }

    public class SchoolService : ISchoolService
    {
        public async Task AddNewSchool(School school)
        {
            using (var context = new AppDbContext())
            {
                await context.Schools.AddAsync(school);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<School>> GetAllSchools()
        {
            using (var context = new AppDbContext())
            {
                return await context.Schools.ToListAsync();
            }
        }
    }
}
