using scvApp.dbcontext;
using scvApp.Models;

namespace scvApp.Services
{
    public interface ISchoolSubmitService
    {
        Task AddNewSchoolSubmit(SchoolSubmit schoolsubmit);
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
    }
}
