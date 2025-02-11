namespace orbis.iim.core.Models.Enum
{
    public enum EnumAction : byte
    {
        Create = 1,
        Read = 2,
        Update = 3,
        Delete = 4,

        Sign = 5,
        Checkout = 6,
        Checkin = 7,

        ChangedVersion = 8
    }
}
