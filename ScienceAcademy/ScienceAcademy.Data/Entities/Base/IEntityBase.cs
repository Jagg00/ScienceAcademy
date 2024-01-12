namespace ScienceAcademy.Data.Entities.Base
{
    public interface IDtoBase
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
    }
}
