using ScienceAcademy.Business.Business.Base;
using ScienceAcademy.Business.Interfaces;
using ScienceAcademy.Data.Dtos;
using ScienceAcademy.Data.Entities;
using ScienceAcademy.Data.Interfaces.IRepositories;
using ScienceAcademy.Data.Repositories;

namespace ScienceAcademy.Business.Business
{
    public class MemberBusiness : BusinessBase, IMemberBusiness
    {
        IMemberRepository MemberRepository { get; set; }

        public MemberBusiness(IMemberRepository memberRepository)
        {
            MemberRepository = memberRepository;
        }

        public Task<MemberDto> AddAsync(MemberDto memberDto)
        {
            // todo: mapper
            var member = MapToMember(memberDto);

            MemberRepository.AddAsync(member);

            return Task.FromResult(memberDto);
        }

        public Task<MemberDto> UpdateAsync(MemberDto memberDto)
        {
            // todo: mapper
            var member = MapToMember(memberDto);

            member = MemberRepository.UpdateAsync(member).Result;

            return Task.FromResult(memberDto);
        }

        public Task<MemberDto> DeleteAsync(MemberDto memberDto)
        {
            var member = MapToMember(memberDto);

            member = MemberRepository.DeleteAsync(member).Result;

            return Task.FromResult(memberDto);
        }

        public Task<MemberDto> GetByIdAsync(Guid Id)
        {
            var member = MemberRepository.GetByIdAsync(Id).Result;
            var memberDto = MapToMemberDto(member);

            return Task.FromResult(memberDto);
        }

        public Task<List<MemberDto>> GetAllAsync()
        {
            List<MemberDto> dtos = new List<MemberDto>();

            var members = MemberRepository.GetAllAsync().Result.ToList();

            foreach (var member in members)
            {
                var memberDto = MapToMemberDto(member);
                dtos.Add(memberDto);
            }

            return Task.FromResult(dtos);
        }

        private static Member MapToMember(MemberDto memberDto)
        {
            // todo: mapper
            var member = new Member
            {
                Id = memberDto.Id,
                Awards = MapToAwardList(memberDto.Awards),
                Biography = memberDto.Biography,
                Created = memberDto.Created,
                Email = memberDto.Email,
                LastName = memberDto.LastName,
                Name = memberDto.Name
            };

            return member;
        }

        private static MemberDto MapToMemberDto(Member member)
        {
            // todo: mapper
            var memberDto = new MemberDto
            {
                Id = member.Id,
                Awards = MapToAwardDtoList(member.Awards),
                Biography = member.Biography,
                Created = member.Created,
                Email = member.Email,
                LastName = member.LastName,
                Name = member.Name
            };

            return memberDto;
        }

        private static List<Award> MapToAwardList(List<AwardDto> awardDtos)
        {
            var awards = new List<Award>();

            foreach (var awardDto in awardDtos)
            {
                var award = AwardBusiness.MapToAward(awardDto);
                awards.Add(award);
            }

            return awards;
        }

        private static List<AwardDto> MapToAwardDtoList(List<Award> awards)
        {
            var awardDtos = new List<AwardDto>();

            foreach (var award in awards)
            {
                var awardDto = AwardBusiness.MapToAwardDto(award);
                awardDtos.Add(awardDto);
            }

            return awardDtos;
        }
    }
}
