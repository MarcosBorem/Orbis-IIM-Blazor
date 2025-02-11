namespace orbis.iim.core.Models
{
    public partial class Version
    {
        public Version()
        {
            Keywordversion = new HashSet<Keywordversion>();
        }

        public Guid Id { get; set; }
        public Guid Document { get; set; }
        public string Filename { get; set; }
        public string Internalfilename { get; set; }
        public Guid Typeof { get; set; }
        public byte Enable { get; set; }
        public byte Status { get; set; }
        public int? Pagesof { get; set; }
        public double? Sizeof { get; set; }
        public bool? Signed { get; set; }
        public string SignedBy { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public Document DocumentNavigation { get; set; }
        public Typeof TypeofNavigation { get; set; }
        public ICollection<Keywordversion> Keywordversion { get; set; }
    }
}
