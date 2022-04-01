using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_Gender")]
    public class MD_Gender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string? Name { get; set; }
        public bool? IsActive { get; set; }

    }
}
