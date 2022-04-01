using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_Address")]
   public class MD_Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Address Name")]
        public string? Name { get; set; }
        [Display(Name = "Postal Code")]
        public string? postalCode { get; set; }
        [Display(Name = "Select District")]
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public virtual MD_District? MD_DistrictId { get; set; }
        [Display(Name = "Select Tehsil")]
        public int TehsilId { get; set; }
        [ForeignKey("TehsilId")]
        public virtual MD_Tehsil? MD_TehsilId { get; set; }

        public bool? IsActive { get; set; }

    }
}
