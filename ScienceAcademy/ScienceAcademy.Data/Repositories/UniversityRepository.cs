using ScienceAcademy.Data.Contexts;
using ScienceAcademy.Data.Entities;
using ScienceAcademy.Data.Generics;
using ScienceAcademy.Data.Interfaces.IRepositories;

namespace ScienceAcademy.Data.Repositories
{
    public class UniversityRepository : GenericRepository<University>, IUniversityRepository
    {
        public UniversityRepository(ScienceAcademyDbContext context) : base(context)
        {
        }
    }
}
