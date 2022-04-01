using NewBlazorProject.Shared.Models.HR_Data;

namespace NewBlazorProject.Server.InterFaces
{
    public interface IHRInterface
    {
       Task<HR_Posting> AddHR_Posting(HR_Posting hR_Posting);
       Task <HR_Designation> AddHR_Designation(HR_Designation hR_Designation);
       Task <HR_Clearance> AddHR_Clearance(HR_Clearance hR_Clearance);
       Task <HR_Catagory> AddHR_Catagory(HR_Catagory hR_Catagory);

        Task<IEnumerable<HR_Posting>> GetAllHR_Posting();
        Task<IEnumerable<HR_Designation>> GetAllHR_Designation();
        Task<IEnumerable<HR_Clearance>> GetAllHR_Clearacne();
        Task<IEnumerable<HR_Catagory>> GetAllHR_Catagory();

        Task<HR_Posting> GetHR_PostingById(int postingId);
        Task<HR_Designation> GetHR_DesignationById(int DesignationId);
        Task<HR_Clearance> GetHR_ClearanceById(int ClearanceId);
        Task<HR_Catagory> GetHR_CatagoryById(int CatagoryId);

        Task <HR_Posting> UpdateHR_Posting(HR_Posting hR_Posting);
        Task<HR_Designation> UpdateHR_Designation(HR_Designation hR_Designation);
        Task<HR_Clearance> UpdateHR_Clearance(HR_Clearance hR_Clearance);
        Task<HR_Catagory> UpdateHR_Catagory(HR_Catagory hR_Catagory);

        void DeleteHR_PostingsById(int PostingId);
        void DeleteHR_Designation(int DesignationId);
        void DeleteHR_Clearance(int ClearanceId);
        void DeleteHR_Catagory(int CatagoryId);
    }
}
