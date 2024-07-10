using EFcoreProject1Core.Models;
using EFcoreProject1Core.Repositories;

namespace EFcoreProject1Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
    }
}
