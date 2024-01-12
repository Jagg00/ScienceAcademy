using ScienceAcademy.Data.Dtos;

namespace ScienceAcademy.Business.Interfaces
{
    public interface IAwardBusiness
    {
        Task<AwardDto> AddAsync(AwardDto awardDto);
        Task<AwardDto> UpdateAsync(AwardDto awardDto);
        Task<AwardDto> DeleteAsync(AwardDto awardDto);
        Task<AwardDto> GetByIdAsync(Guid Id);
        Task<List<AwardDto>> GetAllAsync();
    }
}
