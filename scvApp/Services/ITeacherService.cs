using Microsoft.EntityFrameworkCore;
using scvApp.dbcontext;
using scvApp.Models;

namespace scvApp.Services
{
    public interface ITeacherService
    {
        Task AddNewTeacher(Teacher teacher);

        Task<List<Teacher>> GetAllTeachers();
    }

    public class TeacherService : ITeacherService
    {
        public async Task AddNewTeacher(Teacher teacher)
        {
            using (var context = new AppDbContext())
            {
                await context.Teachers.AddAsync(teacher);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Teacher>> GetAllTeachers()
        {
            using (var context = new AppDbContext())
            {
                return await context.Teachers.ToListAsync();
            }
        }
    }
}
