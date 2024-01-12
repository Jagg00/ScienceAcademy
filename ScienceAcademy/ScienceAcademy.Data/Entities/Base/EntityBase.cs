
using System.ComponentModel.DataAnnotations;

namespace ScienceAcademy.Data.Entities.Base
{
    public class EntityBase : IDtoBase
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
    }
}
