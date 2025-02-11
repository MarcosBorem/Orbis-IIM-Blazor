namespace orbis.iim.core.Models
{
    public partial class Diagram
    {
        public Diagram()
        {
            Versiondiagram = new HashSet<Versiondiagram>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte Enable { get; set; }
        public byte Status { get; set; }
        public Guid? Lastversion { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public ICollection<Versiondiagram> Versiondiagram { get; set; }
    }
}
