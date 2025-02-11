namespace orbis.iim.core.Models
{
    public class MembersRole
    {
        public Guid member_id { get; set; }

        public int? member_level { get; set; }
        public string member_name { get; set; }
        public Guid? parent_id { get; set; }
        public string parent_name { get; set; }
        public string aggid { get; set; }

    }
}
