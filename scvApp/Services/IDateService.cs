using Microsoft.EntityFrameworkCore;
using scvApp.dbcontext;
using scvApp.Models;

namespace scvApp.Services
{
    public interface IDateService
    {
        Task AddNewDate(Date date);

        Task<List<Date>> GetAllDates();

        Task UpdateDate(Date date);

        Task DeleteDate(Date date);
    }

    public class DateService : IDateService
    {
        public async Task AddNewDate(Date date)
        {
            using (var context = new AppDbContext())
            {
                await context.Dates.AddAsync(date);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Date>> GetAllDates()
        {
            using (var context = new AppDbContext())
            {
                return await context.Dates.ToListAsync();
            }
        }

        public async Task UpdateDate(Date date)
        {
            using (var context = new AppDbContext())
            {
                context.Dates.Update(date);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteDate(Date date)
        {
            using (var context = new AppDbContext())
            {
                var oldDate = await context.Dates.FindAsync(date.Id);
                if (oldDate != null)
                {
                    context.Dates.Remove(oldDate);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
