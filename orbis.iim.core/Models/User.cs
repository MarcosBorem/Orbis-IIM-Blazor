namespace orbis.iim.core.Models
{
    public partial class User
    {
        public User()
        {
            //Rule = new HashSet<Rule>();
            UserMemberof = new HashSet<UserMemberof>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Saltpwd { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public byte? Enable { get; set; }
        public byte? Status { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        //public ICollection<Rule> Rule { get; set; }
        public ICollection<UserMemberof> UserMemberof { get; set; }
    }
}
