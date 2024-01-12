using ScienceAcademy.Data.Dtos;

namespace ScienceAcademy.Business.Interfaces
{
    public interface IMemberBusiness
    {
        Task<MemberDto> AddAsync(MemberDto memberDto);
        Task<MemberDto> UpdateAsync(MemberDto memberDto);
        Task<MemberDto> DeleteAsync(MemberDto memberDto);
        Task<MemberDto> GetByIdAsync(Guid Id);
        Task<List<MemberDto>> GetAllAsync();
    }
}
