using NewBlazorProject.Shared.Models.MasterData;

namespace NewBlazorProject.Server.InterFaces
{
    public interface IAdminInterface
    {
        // This is admin interfacses added by saeed
        Task<IEnumerable<MD_Address>> AddAddress(MD_Address mD_Address);
        Task<IEnumerable<MD_CreatedBy>> AddCreatedBy(MD_CreatedBy mD_CreatedBy);
        Task<IEnumerable<MD_Directory>> AddDirectory(MD_Directory mD_Directory);
        Task<IEnumerable<MD_Education>> AddEducation(MD_Education mD_Education);
        Task<IEnumerable<MD_UploadFile>> AddUploadFile(MD_UploadFile mD_UploadFile);
        Task<IEnumerable<MD_UpdatedBy>> AddUpdatedBy(MD_UpdatedBy mD_UpdatedBy);
        Task<IEnumerable<MD_Gender>> AddGender(MD_Gender mD_Gender);
        Task<IEnumerable<MD_District>> AddDistrict(MD_District mD_District);
        Task<IEnumerable<MD_Tehsil>> AddTehsil(MD_Tehsil mD_Tehsil);
        Task<IEnumerable<MD_EducationLevel>> AddEducationLevel(MD_EducationLevel mD_EducationLevel);

        Task<IEnumerable<MD_Address>> GetAllAddress();
        Task<IEnumerable<MD_CreatedBy>> GetAllCreatedBy();
        Task<IEnumerable<MD_Directory>> GetAllDirectory();
        Task<IEnumerable<MD_Education>> GetAllEducation();
        Task<IEnumerable<MD_UploadFile>> GetAllUploadFiles();
        Task<IEnumerable<MD_UpdatedBy>> GetAllUpdatedBy();
        Task<IEnumerable<MD_Gender>> GetAllGender();
        Task<IEnumerable<MD_EducationLevel>> GetAllEducationLevel();
        Task<IEnumerable<MD_District>> GetAllDistrict();
        Task<IEnumerable<MD_Tehsil>> GetAllTehsil();


        Task<MD_Address?> GetAddressById(int? Id);
        Task<MD_CreatedBy?> GetCreatedById(int? Id);
        Task<MD_Directory?> GetDirectoryById(int? Id);
        Task<MD_Education?> GetEductaionBy(int? Id);
        Task<MD_UploadFile?> GetUploadFileById(int? Id);
        Task<MD_UpdatedBy?> GetUpdatedById(int? Id);
        Task<MD_Gender?> GetGenderById(int? Id);
        Task<MD_EducationLevel?> GetEducationLevelById(int? Id);
        Task<MD_District> GetDistrictById(int? Id);
        Task<MD_Tehsil?> GetTehsilById(int? Id);



        Task<MD_Address> UpdateAddress(MD_Address mD_Address);
        Task<MD_CreatedBy> UpdateCreatedBy(MD_CreatedBy mD_Address);
        Task<MD_Directory> UpdateDirectoryBy(MD_Directory mD_Address);
        Task<MD_Education> UpdateEducation(MD_Education mD_Address);
        Task<MD_UploadFile> UpdateUploadFile(MD_UploadFile mD_Address);
        Task<MD_UpdatedBy> UpdateUpdatedBy(MD_UpdatedBy mD_Address);
        Task<MD_Gender> UpdateGender(MD_Gender mD_Address); 
        Task<MD_EducationLevel> UpdateEducationLevel(MD_EducationLevel mD_Address);
        Task<IEnumerable<MD_District>> UpdateDistrict(MD_District mD_District);
        Task<IEnumerable<MD_Tehsil>> UpdateTehsil(MD_Tehsil mD_Tehsil);


        void DeleteAddress(int Id);
        void DeleteCreatedBy(int Id);
        void DeleteDirectory(int Id);
        void DeleteEducation(int Id);
        void DeleteUploadFile(int Id);
        void DeleteUpdatedBy(int Id);
        void DeleteGender(int Id);
        void DeleteEducationLevel(int Id);
        void DeleteDistrict(int Id);
        void DeleteTehsil(int Id);


    }
}
