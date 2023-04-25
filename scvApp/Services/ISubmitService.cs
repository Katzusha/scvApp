using Microsoft.EntityFrameworkCore;
using scvApp.dbcontext;
using scvApp.Models;

namespace scvApp.Services
{
    public interface ISubmitService
    {
        Task AddNewSubmit(Submit submit);

        Task<List<Submit>> GetAllSubmits();

        Task UpdateSubmit(Submit submit);

        Task DeleteSubmit(Submit submit);
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

        public async Task UpdateSubmit(Submit submit)
        {
            using (var context = new AppDbContext())
            {
                context.Submits.Update(submit);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteSubmit(Submit submit)
        {
            using (var context = new AppDbContext())
            {
                var oldSubmit = await context.Submits.FindAsync(submit.Id);
                if (oldSubmit != null)
                {
                    context.Submits.Remove(oldSubmit);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
