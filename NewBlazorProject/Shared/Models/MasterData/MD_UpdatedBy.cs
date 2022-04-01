using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_UpdatedBy")]
    public class MD_UpdatedBy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Updated By")]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Snake Date")]
        [DataType(DataType.DateTime)]
        public DateTime date { get; set; }
        public bool? IsActive { get; set; }
    }
}
