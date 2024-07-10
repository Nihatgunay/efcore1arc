using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFcoreProject1Core.Models;
using EFcoreProject1Core.Repositories;
using EFcoreProject1Data.DAL;

namespace EFcoreProject1Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : IdName, new()
    {
        public AppDBContext _context;

        public GenericRepository()
        {
            _context = new AppDBContext();
        }
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task Insert(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }
    }
}
