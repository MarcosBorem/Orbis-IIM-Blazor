namespace orbis.iim.core.Models.Projections
{
    public class ResourcesTreeProjections
    {
        public Guid resource_id { get; set; }
        public int resource_level { get; set; }
        public string resource_name { get; set; }
        public string resource_label { get; set; }
        public byte? resource_type { get; set; }
        public byte? resource_status { get; set; }
        public Guid? resource_parent { get; set; }
        public string resource_aggid { get; set; }
    }
}
