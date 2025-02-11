namespace orbis.iim.core.Models
{
    public partial class Historic
    {
        public Guid Id { get; set; }
        public Guid Document { get; set; }
        public byte Action { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid CreatedBy { get; set; }

        public Document DocumentNavigation { get; set; }
    }
}
