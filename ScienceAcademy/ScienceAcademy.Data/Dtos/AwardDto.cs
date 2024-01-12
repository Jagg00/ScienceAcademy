using ScienceAcademy.Data.Dtos.Base;

namespace ScienceAcademy.Data.Dtos
{
    public class AwardDto : DtoBase
    {
        public DateTime AwardedAt { get; set; }
        public string Name { get; set; }

        public AwardDto(DateTime awardedAt, string name)
        {
            AwardedAt = awardedAt;
            Name = name;
        }
    }
}
