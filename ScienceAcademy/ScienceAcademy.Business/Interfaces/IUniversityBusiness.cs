using ScienceAcademy.Data.Dtos;

namespace ScienceAcademy.Business.Interfaces
{
    public interface IUniversityBusiness
    {
        Task<UniversityDto> AddAsync(UniversityDto universityDto);
        Task<UniversityDto> UpdateAsync(UniversityDto universityDto);
        Task<UniversityDto> DeleteAsync(UniversityDto universityDto);
        Task<UniversityDto> GetByIdAsync(Guid Id);
        Task<List<UniversityDto>> GetAllAsync();
    }
}
