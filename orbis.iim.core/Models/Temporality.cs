namespace orbis.iim.core.Models
{
    public partial class Temporality
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? PhaseCurrent { get; set; }
        public int? PhaseIntermediate { get; set; }
        public byte? PhaseFinal { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public byte? Enable { get; set; }
        public byte? Status { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public ICollection<Typeof> Typeof { get; set; }
    }
}
