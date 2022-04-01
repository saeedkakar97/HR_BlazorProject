using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models
{
    internal class Profile
    {
        public int HRID { get; set; }
        public  int CatagoryID { get; set; }
        public string? PersonalNo { get; set; }
        public string? BeltNo { get; set; }
        public string? CNIC { get; set; }
        public string? CNICFrontPath { get; set; }
        public string? CNICBackPath { get; set; }
        public string? PicturePath { get; set; }
        public string? Name { get; set; }
        public string? FatherName { get; set; }
        public int GenderID { get; set; }
        public string? ContactNo { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime DateJoining { get; set; }
        public DateTime DateSuperannuation { get; set; }
        public int DistrictID { get; set; }
        public int RecruitmentDistrictID { get; set; }
        public int PostingDistrictID { get; set; }
        public DateTime LastPromotionDate { get; set; }
        public string? LocalImagePath { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? NextOfKin { get; set; }
        public string? NOKContact { get; set; }
        public int ClearanceID { get; set; }
        public string? ClearanceCertificatePath { get; set; }
        public int DesignationID { get; set; }
        public int StepCompetedUpto { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? Verified { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime VerifiedDate { get; set; }
        public bool? IsBiometricReg { get; set; }
        public string? BioLeftIndex { get; set; }
        public string? BioLeftThumb { get; set; }
        public string? BioRightIndex { get; set; }
        public string? BioRighThumb { get; set; }
        public bool? IsActive { get; set; }






    }
}
