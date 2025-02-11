namespace orbis.iim.core.Models
{
    public partial class Document
    {
        public Document()
        {
            Version = new HashSet<Version>();
        }

        public Guid Id { get; set; }
        public byte Enable { get; set; }
        public byte Status { get; set; }
        public Guid? Lastversion { get; set; }
        public Guid? TypeofLastversion { get; set; }
        public int? PagesofLastversion { get; set; }
        public double? SizeofLastversion { get; set; }
        public int? phaseTemporality { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public string Content { get; set; }

        public Typeof TypeofLastversionNavigation { get; set; }
        public ICollection<Historic> Historic { get; set; }
        public ICollection<Version> Version { get; set; }
    }
}
