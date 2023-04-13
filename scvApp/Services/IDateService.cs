using Microsoft.EntityFrameworkCore;
using scvApp.dbcontext;
using scvApp.Models;

namespace scvApp.Services
{
    public interface IDateService
    {
        Task AddNewDate(Date date);

        Task<List<Date>> GetAllDates();
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
    }
}
