namespace orbis.iim.core.Models
{
    public partial class Keywordtypeof
    {
        public Keywordtypeof()
        {
            Keywordversion = new HashSet<Keywordversion>();
        }

        public Guid Id { get; set; }
        public Guid Typeof { get; set; }
        public Guid Keyword { get; set; }
        public short Order { get; set; }
        public byte? Enable { get; set; }
        public byte? Status { get; set; }
        public string Content { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public Keyword KeywordNavigation { get; set; }
        public Typeof TypeofNavigation { get; set; }
        public ICollection<Keywordversion> Keywordversion { get; set; }
    }
}
