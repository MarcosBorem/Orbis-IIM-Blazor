using System.ComponentModel.DataAnnotations;

namespace orbis.iim.core.Models
{
    public class Tenant
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Config { get; set; } // SqlServer does not support jsonb format

        public byte? Enable { get; set; }

        public byte? Status { get; set; }

        public DateTime? CreatedWhen { get; set; } = DateTime.Now;

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedWhen { get; set; }

        public Guid? ModifiedBy { get; set; }

    }
}
