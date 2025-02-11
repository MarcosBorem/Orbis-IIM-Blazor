namespace orbis.iim.core.Models
{
    public class Permission
    {
        public string resource_label { get; set; }
        public string action_label { get; set; }

        public Guid resource_id { get; set; }

    }
}
