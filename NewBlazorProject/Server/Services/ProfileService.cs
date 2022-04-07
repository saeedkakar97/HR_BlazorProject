
using Microsoft.EntityFrameworkCore;
using NewBlazorProject.Server.Data;
using NewBlazorProject.Server.InterFaces;
using NewBlazorProject.Shared.Models;

namespace NewBlazorProject.Server.Services
{
    public class ProfileService : IProfileInterface
    {
        private readonly ApplicationDbContext _context;
        public ProfileService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Profile>> AddAddress(Profile profile)
        {
            var result = await _context.Profiles.AddAsync(profile);
            await _context.SaveChangesAsync();
            return (IEnumerable<Profile>)result.Entity;
        }

        public async void DeleteAddress(int Id) 
        {
            var result = await _context.Profiles
               .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _context.Profiles.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Profile?> GetAddressById(int? Id)
        {
            return await _context.Profiles
               .FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IEnumerable<Profile>> GetAllAddress()
        {
            return await _context.Profiles.ToListAsync();
        } 

        public async Task<Profile> UpdateAddress(Profile profile)
        {
            var result = await _context.Profiles.FirstOrDefaultAsync(e => e.Id == profile.Id);
            if (result != null)
            {
                result.Name = profile.Name;
                result.HRID = profile.HRID;
                result.CatagoryID = profile.CatagoryID;
                result.PersonalNo = profile.PersonalNo;
                result.BeltNo = profile.BeltNo;
                result.CNIC = profile.CNIC;
                result.CNICFrontPath = profile.CNICFrontPath;
                result.CNICBackPath = profile.CNICBackPath;
                result.PicturePath = profile.PicturePath;
                result.FatherName = profile.FatherName;
                result.GenderID = profile.GenderID;
                result.ContactNo = profile.ContactNo;
                result.DOB = profile.DOB;
                result.DateOrder = profile.DateOrder;
                result.DateJoining = profile.DateJoining;
                result.DateSuperannuation = profile.DateSuperannuation;
                result.DistrictID = profile.DistrictID;
                result.RecruitmentDistrictID = profile.RecruitmentDistrictID;
                result.PostingDistrictID = profile.PostingDistrictID;
                result.LastPromotionDate = profile.LastPromotionDate;
                result.LocalImagePath = profile.LocalImagePath;
                result.Height = profile.Height;
                result.Weight = profile.Weight;
                result.NextOfKin = profile.NextOfKin;
                result.NOKContact = profile.NOKContact;
                result.ClearanceID = profile.ClearanceID;
                result.ClearanceCertificatePath = profile.ClearanceCertificatePath;
                result.DesignationID = profile.DesignationID;
                result.CreatedDate = profile.CreatedDate;
                result.CreatedBy = profile.CreatedBy;
                result.VerifiedBy = profile.VerifiedBy;
                result.VerifiedBy = profile.VerifiedBy;
                result.IsBiometricReg = profile.IsBiometricReg;
                result.BioLeftIndex = profile.BioLeftIndex;
                result.BioRighThumb = profile.BioRighThumb;
                result.BioLeftThumb = profile.BioLeftThumb;
                result.BioRightIndex = profile.BioRightIndex;
                result.PersonalNo = profile.PersonalNo;
                result.PicturePath = profile.PicturePath;
                result.PostingDistrictID = profile.PostingDistrictID;
                result.RecruitmentDistrictID = profile.RecruitmentDistrictID;
                result.StepCompetedUpto = profile.StepCompetedUpto;
                result.UpdatedBy = profile.UpdatedBy;
                result.UpdatedDate = profile.UpdatedDate;
                result.Verified = profile.Verified;
                
                

                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
