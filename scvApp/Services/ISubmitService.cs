using Microsoft.EntityFrameworkCore;
using scvApp.dbcontext;
using scvApp.Models;

namespace scvApp.Services
{
    public interface ISubmitService
    {
        Task AddNewSubmit(Submit submit);

        Task<List<Submit>> GetAllSubmits();
    }

    public class SubmitService : ISubmitService
    {
        public async Task AddNewSubmit(Submit submit)
        {
            using (var context = new AppDbContext())
            {
                await context.Submits.AddAsync(submit);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Submit>> GetAllSubmits()
        {
            using (var context = new AppDbContext())
            {
                return await context.Submits.ToListAsync();
            }
        }
    }
}
