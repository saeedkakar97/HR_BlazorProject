using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewBlazorProject.Shared.Models.HR_Data
{
    [Table("HR_Clearance")]
    public class HR_Clearance
    {
        [Key]
        public int id { get; set; }
        public string? ProfileId { get; set; }
        public bool Status { get; set; } = false;
    }
}
