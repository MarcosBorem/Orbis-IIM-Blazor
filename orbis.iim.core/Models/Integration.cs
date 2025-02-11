namespace orbis.iim.core.Models
{
    public partial class Integration
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Url { get; set; }
        public string headers { get; set; }
        public string parameters { get; set; }
        public byte? Method { get; set; }
        public Guid? Typeof { get; set; }
        public byte? integrationtype { get; set; }
        public string Content { get; set; }
        public byte? Enable { get; set; }
        public byte? Status { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
