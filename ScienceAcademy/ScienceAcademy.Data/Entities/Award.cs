using ScienceAcademy.Data.Entities.Base;

namespace ScienceAcademy.Data.Entities
{
    public class Award : EntityBase
    {
        public DateTime AwardedAt { get; set; }
        public string Name { get; set; }
    }
}
