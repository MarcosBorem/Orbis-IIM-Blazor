namespace orbis.iim.core.Models
{
    public partial class Typeof
    {
        public Typeof()
        {
            Document = new HashSet<Document>();
            Keywordtypeof = new HashSet<Keywordtypeof>();
            Version = new HashSet<Version>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public byte? Enable { get; set; }
        public byte? Status { get; set; }
        public byte? Type { get; set; }
        public int? TotalDocuments { get; set; }
        public double? SizeofDocuments { get; set; }
        public DateTime? LastdocumentWhen { get; set; }
        public Guid? LastdocumentBy { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }
        public Guid? Temporality { get; set; }

        public Temporality TemporalityNavigation { get; set; }
        public ICollection<Document> Document { get; set; }
        public ICollection<Keywordtypeof> Keywordtypeof { get; set; }
        public ICollection<Version> Version { get; set; }
    }
}
