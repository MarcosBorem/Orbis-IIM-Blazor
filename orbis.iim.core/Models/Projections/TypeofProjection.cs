namespace orbis.iim.core.Models.Projections
{
    public class TypeofProjection
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public Guid KeywordId { get; set; }
        public string Keyworkd { get; set; }
        public int Type { get; set; }
        public int? Length { get; set; }
        public string Content { get; set; }
        public string TypeDetails { get; set; }
    }
}
