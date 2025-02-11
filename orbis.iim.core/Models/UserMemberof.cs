namespace orbis.iim.core.Models
{
    public partial class UserMemberof
    {
        public Guid Id { get; set; }
        public Guid User { get; set; }
        public Guid Role { get; set; }
        public byte? Enable { get; set; }
        public byte? Status { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public Role RoleNavigation { get; set; }
        public User UserNavigation { get; set; }
    }
}
