using NewBlazorProject.Server.InterFaces;
using NewBlazorProject.Shared.Models.MasterData;

namespace NewBlazorProject.Server.Services
{
    public class AdminService : IAdminInterface
    {
        // comment add by saeed
        public MD_Address? AddAddress(MD_Address mD_Address)
        {
           if(mD_Address == null)
            {
                MD_Address model = new MD_Address()
                {
                    Name = mD_Address.Name,
                    postalCode = mD_Address.postalCode
                };
                return model;
            }
            return null;
        }
        

        public MD_CreatedBy AddCreatedBy(MD_CreatedBy mD_CreatedBy)
        {
            throw new NotImplementedException();
        }

        public MD_Directory AddDirectory(MD_Directory mD_Directory)
        {
            throw new NotImplementedException();
        }

        public MD_Education AddEducation(MD_Education mD_Education)
        {
            throw new NotImplementedException();
        }

        public MD_EducationLevel AddEducationLevel(MD_EducationLevel mD_EducationLevel)
        {
            throw new NotImplementedException();
        }

        public MD_Gender AddGender(MD_Gender mD_Gender)
        {
            throw new NotImplementedException();
        }

        public MD_UpdatedBy AddUpdatedBy(MD_UpdatedBy mD_UpdatedBy)
        {
            throw new NotImplementedException();
        }

        public MD_UploadFile AddUploadFile(MD_UploadFile mD_UploadFile)
        {
            throw new NotImplementedException();
        }

        public void DeleteAddress(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCreatedBy(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDirectory(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteEducation(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteEducationLevel(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteGender(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteUpdatedBy(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteUploadFile(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<MD_Address> GetAddressById(int Id)
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

        public Task<MD_CreatedBy> GetCreatedById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<MD_Directory> GetDirectoryById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<MD_EducationLevel> GetEducationLevelById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<MD_Education> GetEductaionBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<MD_Gender> GetGenderById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<MD_UpdatedBy> GetUpdatedById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<MD_UploadFile> GetUploadFileById(int Id)
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
