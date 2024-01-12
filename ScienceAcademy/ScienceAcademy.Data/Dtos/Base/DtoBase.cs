
using System.ComponentModel.DataAnnotations;

namespace ScienceAcademy.Data.Dtos.Base
{
    public class DtoBase : IDtoBase
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
    }
}
