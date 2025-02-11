namespace orbis.iim.core.Models.Projections
{
    public class RolesProjections
    {
        public Guid role_id { get; set; }
        public IEnumerable<RolesProjections> role_members { get; set; }
    }
}
