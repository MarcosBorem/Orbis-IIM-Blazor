namespace orbis.iim.core.Models
{
    public partial class Keyword
    {
        public Keyword()
        {
            Keywordtypeof = new HashSet<Keywordtypeof>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public int Type { get; set; }
        public int? Length { get; set; }
        public string Content { get; set; }
        public byte? Enable { get; set; }
        public byte? Status { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public ICollection<Keywordtypeof> Keywordtypeof { get; set; }
    }
}
