using ScienceAcademy.Data.Contexts;
using ScienceAcademy.Data.Entities;
using ScienceAcademy.Data.Generics;
using ScienceAcademy.Data.Interfaces.IRepositories;

namespace ScienceAcademy.Data.Repositories
{
    public class AwardRepository : GenericRepository<Award>, IAwardRepository
    {
        public AwardRepository(ScienceAcademyDbContext context) : base(context)
        {
        }
    }
}
