namespace orbis.iim.core.Models
{
    public partial class Keywordversion
    {
        public Guid Id { get; set; }
        public Guid Version { get; set; }
        public Guid Keywordtypeof { get; set; }
        public byte Enable { get; set; }
        public byte Status { get; set; }
        public string Value { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public Keywordtypeof KeywordtypeofNavigation { get; set; }
        public Version VersionNavigation { get; set; }
    }
}
