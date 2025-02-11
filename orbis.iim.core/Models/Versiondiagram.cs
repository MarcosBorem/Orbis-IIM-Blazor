namespace orbis.iim.core.Models
{
    public partial class Versiondiagram
    {
        public Guid Id { get; set; }
        public Guid Diagram { get; set; }
        public int Version { get; set; }
        public string Xml { get; set; }
        public string Attributes { get; set; }
        public string Content { get; set; }
        public string Comments { get; set; }
        public byte Enable { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public Diagram DiagramNavigation { get; set; }
    }
}
