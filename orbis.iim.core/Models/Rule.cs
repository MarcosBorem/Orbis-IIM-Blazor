namespace orbis.iim.core.Models
{
    public partial class Rule
    {
        public Guid Id { get; set; }
        public Guid RoleOrUser { get; set; }
        public Guid? Resource { get; set; }
        public Guid? Action { get; set; }
        public bool? Allowed { get; set; }
        public byte? Enable { get; set; }
        public byte? Status { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }
        public Role RoleNavigation { get; set; }
    }
}
