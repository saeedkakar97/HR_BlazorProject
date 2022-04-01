using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models.HR_Data
{
    [Table("HR_Posting")]
    public class HR_Posting
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? PostingArea { get; set; }
        public string? ServiceDuration { get; set; }
        public bool? StillEmployee { get; set; }

    }
}
