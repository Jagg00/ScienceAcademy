using ScienceAcademy.Business.Business.Base;
using ScienceAcademy.Business.Interfaces;
using ScienceAcademy.Data.Dtos;
using ScienceAcademy.Data.Entities;
using ScienceAcademy.Data.Interfaces.IRepositories;

namespace ScienceAcademy.Business.Business
{
    public class AwardBusiness : BusinessBase, IAwardBusiness
    {
        IAwardRepository AwardRepository { get; set; }

        public AwardBusiness(IAwardRepository awardRepository)
        {
            AwardRepository = awardRepository;
        }

        public Task<AwardDto> AddAsync(AwardDto awardDto)
        {
            // todo: mapper
            var award = MapToAward(awardDto);

            AwardRepository.AddAsync(award);

            return Task.FromResult(awardDto);
        }

        public Task<AwardDto> UpdateAsync(AwardDto awardDto)
        {
            // todo: mapper
            var award = MapToAward(awardDto);

            award = AwardRepository.UpdateAsync(award).Result;

            return Task.FromResult(awardDto);
        }

        public Task<AwardDto> DeleteAsync(AwardDto awardDto)
        {
            var award = MapToAward(awardDto);

            award = AwardRepository.DeleteAsync(award).Result;

            return Task.FromResult(awardDto);
        }

        public Task<AwardDto> GetByIdAsync(Guid Id)
        {
            var award = AwardRepository.GetByIdAsync(Id).Result;
            var awardDto = MapToAwardDto(award);

            return Task.FromResult(awardDto);
        }

        public Task<List<AwardDto>> GetAllAsync()
        {
            List<AwardDto> dtos = new List<AwardDto>();

            var awards = AwardRepository.GetAllAsync().Result.ToList();

            foreach (var award in awards)
            {
                var awardDto = MapToAwardDto(award);
                dtos.Add(awardDto);
            }

            return Task.FromResult(dtos);
        }

        public static Award MapToAward(AwardDto awardDto)
        {
            // todo: mapper
            var award = new Award
            {
                Id = Guid.NewGuid(),
                Name = awardDto.Name,
                AwardedAt = awardDto.AwardedAt,
                Created = DateTime.Now
            };

            return award;
        }

        public static AwardDto MapToAwardDto(Award award)
        {
            // todo: mapper
            var awardDto = new AwardDto(award.AwardedAt, award.Name)
            {
                Id = award.Id,
                Name = award.Name,
                AwardedAt = award.AwardedAt,
                Created = DateTime.Now
            };

            return awardDto;
        }
    }
}
