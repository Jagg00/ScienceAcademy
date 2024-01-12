using ScienceAcademy.Business.Business.Base;
using ScienceAcademy.Business.Interfaces;
using ScienceAcademy.Data.Dtos;
using ScienceAcademy.Data.Entities;
using ScienceAcademy.Data.Interfaces.IRepositories;
using ScienceAcademy.Data.Repositories;

namespace ScienceAcademy.Business.Business
{
    public class UniversityBusiness : BusinessBase, IUniversityBusiness
    {
        IUniversityRepository UniversityRepository { get; set; }

        public UniversityBusiness(IUniversityRepository universityRepository)
        {
            UniversityRepository = universityRepository;
        }

        public Task<UniversityDto> AddAsync(UniversityDto universityDto)
        {
            // todo: mapper
            var university = MapToUniversity(universityDto);

            UniversityRepository.AddAsync(university);

            return Task.FromResult(universityDto);
        }

        public Task<UniversityDto> UpdateAsync(UniversityDto universityDto)
        {
            // todo: mapper
            var university = MapToUniversity(universityDto);

            university = UniversityRepository.UpdateAsync(university).Result;

            return Task.FromResult(universityDto);
        }

        public Task<UniversityDto> DeleteAsync(UniversityDto universityDto)
        {
            var university = MapToUniversity(universityDto);

            university = UniversityRepository.DeleteAsync(university).Result;

            return Task.FromResult(universityDto);
        }

        public Task<UniversityDto> GetByIdAsync(Guid Id)
        {
            var university = UniversityRepository.GetByIdAsync(Id).Result;
            var universityDto = MapToUniversityDto(university);

            return Task.FromResult(universityDto);
        }

        private static University MapToUniversity(UniversityDto universityDto)
        {
            // todo: mapper
            var university = new University
            {
                Id = universityDto.Id,
                Name = universityDto.Name,
                Created = universityDto.Created
            };

            return university;
        }

        public Task<List<UniversityDto>> GetAllAsync()
        {
            List<UniversityDto> dtos = new List<UniversityDto>();

            var universities = UniversityRepository.GetAllAsync().Result.ToList();

            foreach (var university in universities)
            {
                var uniDto = MapToUniversityDto(university);
                dtos.Add(uniDto);
            }

            return Task.FromResult(dtos);
        }

        private static UniversityDto MapToUniversityDto(University university)
        {
            // todo: mapper
            var universityDto = new UniversityDto
            {
                Id = university.Id,
                Name = university.Name,
                Created = university.Created
            };

            return universityDto;
        }
    }
}
