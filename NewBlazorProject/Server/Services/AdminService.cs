using Microsoft.EntityFrameworkCore;
using NewBlazorProject.Server.Data;
using NewBlazorProject.Server.InterFaces;
using NewBlazorProject.Shared.Models.MasterData;

namespace NewBlazorProject.Server.Services
{
    public class AdminService : IAdminInterface
    {
        private readonly ApplicationDbContext _context;
        public AdminService(ApplicationDbContext context)
        {
            _context = context;
        }

       async Task<IEnumerable<MD_Address>>  IAdminInterface.AddAddress(MD_Address mD_Address)
        {
            var result = await _context.MD_Addresses.AddAsync(mD_Address);
            await _context.SaveChangesAsync();
            return (IEnumerable<MD_Address>)result.Entity;
        }

       async Task<IEnumerable<MD_CreatedBy>> IAdminInterface.AddCreatedBy(MD_CreatedBy mD_CreatedBy)
        {
            var result = await _context.MD_CreatedBy.AddAsync(mD_CreatedBy);
            await _context.SaveChangesAsync();
            return (IEnumerable<MD_CreatedBy>)result.Entity;
        }

       async Task<IEnumerable<MD_Directory>> IAdminInterface.AddDirectory(MD_Directory mD_Directory)
        {
            var result = await _context.MD_Directories.AddAsync(mD_Directory);
            await _context.SaveChangesAsync();
            return (IEnumerable<MD_Directory>)result.Entity;
        }

       async Task<IEnumerable<MD_Education>> IAdminInterface.AddEducation(MD_Education mD_Education)
        {
            var result = await _context.MD_Educations.AddAsync(mD_Education);
            await _context.SaveChangesAsync();
            return (IEnumerable<MD_Education>)result.Entity;
        }

       async Task<IEnumerable<MD_EducationLevel>> IAdminInterface.AddEducationLevel(MD_EducationLevel mD_EducationLevel)
        {
            var result = await _context.MD_EducationLevels.AddAsync(mD_EducationLevel);
            await _context.SaveChangesAsync();
            return (IEnumerable<MD_EducationLevel>)result.Entity;
        }

       async Task<IEnumerable<MD_Gender>> IAdminInterface.AddGender(MD_Gender mD_Gender)
        {
            var result = await _context.MD_Genders.AddAsync(mD_Gender);
            await _context.SaveChangesAsync();
            return (IEnumerable<MD_Gender>)result.Entity;
        }

       async Task<IEnumerable<MD_UpdatedBy>> IAdminInterface.AddUpdatedBy(MD_UpdatedBy mD_UpdatedBy)
        {
            var result = await _context.MD_UpdatedBys.AddAsync(mD_UpdatedBy);
            await _context.SaveChangesAsync();
            return (IEnumerable<MD_UpdatedBy>)result.Entity;
        }

       async Task<IEnumerable<MD_UploadFile>> IAdminInterface.AddUploadFile(MD_UploadFile mD_UploadFile)
        {
            var result = await _context.MD_UploadFiles.AddAsync(mD_UploadFile);
            await _context.SaveChangesAsync();
            return (IEnumerable<MD_UploadFile>)result.Entity;
        }
       


        public async void DeleteAddress(int Id)
        {
            var result = await _context.MD_Addresses
              .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _context.MD_Addresses.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteCreatedBy(int Id)
        {
            var result = await _context.MD_CreatedBy
             .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _context.MD_CreatedBy.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteDirectory(int Id)
        {
            var result = await _context.MD_Directories
             .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _context.MD_Directories.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteEducation(int Id)
        {
            var result = await _context.MD_Educations
             .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _context.MD_Educations.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteEducationLevel(int Id)
        {
            var result = await _context.MD_EducationLevels
             .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _context.MD_EducationLevels.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteGender(int Id)
        {
            var result = await _context.MD_Genders
              .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _context.MD_Genders.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteUpdatedBy(int Id)
        {
            var result = await _context.MD_UpdatedBys
             .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _context.MD_UpdatedBys.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteUploadFile(int Id)
        {
            var result = await _context.MD_UploadFiles
             .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _context.MD_UploadFiles.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<MD_Address?> GetAddressById(int? Id)
        {
            return await _context.MD_Addresses.FirstOrDefaultAsync(e => e.Id == Id);
        }
        public async Task<MD_CreatedBy?> GetCreatedById(int? Id)
        {
            return await _context.MD_CreatedBy.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<MD_Directory?> GetDirectoryById(int? Id)
        {
            return await _context.MD_Directories.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<MD_EducationLevel?> GetEducationLevelById(int? Id)
        {
            return await _context.MD_EducationLevels.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<MD_Education?> GetEductaionBy(int? Id)
        {
            return await _context.MD_Educations.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<MD_Gender?> GetGenderById(int? Id)
        {
            return await _context.MD_Genders.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<MD_UpdatedBy?> GetUpdatedById(int? Id)
        {
            return await _context.MD_UpdatedBys.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public Task<MD_UploadFile> GetUploadFileById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MD_Address>> GetAllAddress()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MD_CreatedBy>> GetAllCreatedBy()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MD_Directory>> GetAllDirectory()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MD_Education>> GetAllEducation()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MD_EducationLevel>> GetAllEducationLevel()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MD_Gender>> GetAllGender()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MD_UpdatedBy>> GetAllUpdatedBy()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MD_UploadFile>> GetAllUploadFiles()
        {
            throw new NotImplementedException();
        }

       

        public void UpdateAddress(MD_Address mD_Address)
        {
            throw new NotImplementedException();
        }

        public void UpdateCreatedBy(MD_CreatedBy mD_CreatedBy)
        {
            throw new NotImplementedException();
        }

        public void UpdateDirectoryBy(MD_Directory mD_Directory)
        {
            throw new NotImplementedException();
        }

        public void UpdateEducation(MD_Education mD_Education)
        {
            throw new NotImplementedException();
        }

        public void UpdateEducationLevel(MD_EducationLevel mD_EducationLevel)
        {
            throw new NotImplementedException();
        }

        public void UpdateGender(MD_Gender mD_Gender)
        {
            throw new NotImplementedException();
        }

        public void UpdateUpdatedBy(MD_UpdatedBy mD_UpdateUpdatedBy)
        {
            throw new NotImplementedException();
        }

        public void UpdateUploadFile(MD_UploadFile mD_UploadFile)
        {
            throw new NotImplementedException();
        }

       

       
    }
}
