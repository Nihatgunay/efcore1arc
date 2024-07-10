using EFcoreProject1Core.Models;

namespace EFcoreProject1Business.Interfaces
{
    public interface ITeacherService
    {
        Task DeleteAsync(int id);
        Task CreateAsync(Teacher teacher);
        Task<Teacher> GetById(int id);
        Task<List<Teacher>> GetAllAsync();
        Task UpdateAsync(Teacher teacher);
    }
}
