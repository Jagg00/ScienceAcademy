using ScienceAcademy.Data.Dtos.Base;

namespace ScienceAcademy.Data.Dtos
{
    public class MemberDto : DtoBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }
        public List<AwardDto> Awards { get; set; }
    }
}
