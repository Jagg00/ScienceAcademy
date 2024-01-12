using ScienceAcademy.Data.Entities.Base;

namespace ScienceAcademy.Data.Entities
{
    public class Member : EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }
        public List<Award> Awards { get; set; }
    }
}
