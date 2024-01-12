using ScienceAcademy.Data.Contexts;
using ScienceAcademy.Data.Entities;
using ScienceAcademy.Data.Generics;
using ScienceAcademy.Data.Interfaces.IRepositories;

namespace ScienceAcademy.Data.Repositories
{
    public class MemberRepository : GenericRepository<Member>, IMemberRepository
    {
        public MemberRepository(ScienceAcademyDbContext context) : base(context)
        {
        }
    }
}
