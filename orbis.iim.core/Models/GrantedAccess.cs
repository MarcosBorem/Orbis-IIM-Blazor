namespace orbis.iim.core.Models
{
    public class GrantedAccess
    {
        public byte resource_type { get; set; }
        public string resource_label { get; set; }
        public string action_label { get; set; }
        public Guid resource_id { get; set; }
    }
}
