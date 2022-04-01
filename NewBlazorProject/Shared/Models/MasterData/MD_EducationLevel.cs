using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_EducationLevel")]
    public class MD_EducationLevel
    {
        [Key]
        public int? Id { get; set; }
        public string  Name { get; set; }


    }
}
