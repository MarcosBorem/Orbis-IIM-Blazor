namespace orbis.iim.core.Models
{
    public partial class Action
    {
        public Action()
        {
            Rule = new HashSet<Rule>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public byte? Enable { get; set; }
        public byte? Status { get; set; }
        public byte? Type { get; set; }
        public DateTime CreatedWhen { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
        public Guid? ModifiedBy { get; set; }

        public ICollection<Rule> Rule { get; set; }
    }
}
