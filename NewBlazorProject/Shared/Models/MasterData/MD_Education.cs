using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_Education")]
    public class MD_Education
    {
        [Key]
        public int? Id { get; set; }
        [Display(Name = "Obtain Marks")]
        public string? ObtainMark { get; set; }
        [Display(Name = "Total Marks")]
        public string? TotalMark { get; set; }
        [Display(Name = "CGPA")]
        public decimal? CGPA { get; set; }
        [Display(Name = "Percentage")]
        public decimal? Percentage { get; set; }
        [NotMapped]
        public List<bool>? SelectLevel { get; set; }
        public bool? IsActive { get; set; }

    }
}
