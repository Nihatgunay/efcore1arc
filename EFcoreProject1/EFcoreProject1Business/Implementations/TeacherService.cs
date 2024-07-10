using EFcoreProject1Business.Interfaces;
using EFcoreProject1Core.Models;
using EFcoreProject1Core.Repositories;
using EFcoreProject1Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EFcoreProject1Business.Implementations
{
    public class TeacherService : ITeacherService
    {
        private ITeacherRepository _repository;
        public TeacherService()
        {
            _repository = new TeacherRepository();
        }

        public async Task CreateAsync(Teacher teacher)
        {
            await _repository.Insert(teacher);
            await _repository.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repository.GetAsync(id);
            if (data == null)
            {
                throw new NullReferenceException();
            }
            _repository.Delete(data);
            await _repository.CommitAsync();
        }

        public async Task<List<Teacher>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<Teacher> GetById(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task UpdateAsync(Teacher teacher)
        {
            var existdata = await _repository.GetAsync(teacher.Id);
            if (existdata == null)
            {
                throw new NullReferenceException();
            }
            existdata.Name = teacher.Name;
            existdata.Salary = teacher.Salary;
            
        }
    }
}
