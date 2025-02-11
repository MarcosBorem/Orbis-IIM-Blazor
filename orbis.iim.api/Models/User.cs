using Microsoft.AspNetCore.Identity;

namespace orbis.iim.api.Models;

public class User : IdentityUser<long>
{
    public List<IdentityRole<long>>? Roles { get; set; }
}