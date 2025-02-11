namespace orbis.iim.core.Models
{
    public partial class AllResources
    {
        public Guid resource_id { get; set; }
        public int resource_level { get; set; }
        public string resource_label { get; set; }
        public byte? resource_type { get; set; }
        public string resource_agg { get; set; }
        public Guid? action_id { get; set; }
        public string action_label { get; set; }
    }
}
