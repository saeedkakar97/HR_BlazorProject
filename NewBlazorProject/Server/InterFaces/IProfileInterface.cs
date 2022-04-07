


using NewBlazorProject.Shared.Models;

namespace NewBlazorProject.Server.InterFaces
{
    public interface IProfileInterface
    {
        Task<IEnumerable<Profile>> AddAddress(Profile profile);
        Task<IEnumerable<Profile>> GetAllAddress();
        Task<Profile?> GetAddressById(int? Id);
        Task<Profile> UpdateAddress(Profile mD_Address);
        void DeleteAddress(int Id);
    }
}
