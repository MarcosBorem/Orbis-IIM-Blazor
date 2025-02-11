namespace orbis.iim.core.Models
{
    public partial class Role
    {
        public Role()
        {
            InverseMemberofNavigation = new HashSet<Role>();
            Rule = new HashSet<Rule>();
            UserMemberof = new HashSet<UserMemberof>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte? Enable { get; set; }
        public byte? Status { get; set; }
        public Guid? Memberof { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public Role MemberofNavigation { get; set; }
        public ICollection<Role> InverseMemberofNavigation { get; set; }
        public ICollection<Rule> Rule { get; set; }
        public ICollection<UserMemberof> UserMemberof { get; set; }
    }
}
