using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_Directory")]
    public class MD_Directory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Folder Name")]
        public string? FolderName { get; set; }     
        [Display(Name = "SubFolder Name")]
        public string? SubFolderName { get; set; }
        public virtual ICollection<MD_UploadFile>? MD_UploadFiles { get; set; }


    }
}
