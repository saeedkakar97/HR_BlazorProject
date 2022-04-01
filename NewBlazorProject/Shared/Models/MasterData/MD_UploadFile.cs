using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_UploadFile")]
    public class MD_UploadFile
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Select File")]
        public string? Path { get; set; }
        [Display(Name ="Select Multiple Files")]
        [NotMapped]
        public List<string>? MultiplePath { get; set; } 
        [Display(Name ="Select Directory")]
        public int DirectoryId { get; set; }
        [ForeignKey("DirectoryId")]
        public virtual MD_Directory? MD_Directory { get; set; }



    }
}
