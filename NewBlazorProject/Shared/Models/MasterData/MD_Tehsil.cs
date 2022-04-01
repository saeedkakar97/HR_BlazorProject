using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_Tehsil")]
    public class MD_Tehsil
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tehsil Name")]
        public string? Name { get; set; }
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public virtual MD_District? District { get; set; }
        public bool? IsActive { get; set; }
    }
}
