using Microsoft.EntityFrameworkCore;
using NewBlazorProject.Server.Data;
using NewBlazorProject.Server.InterFaces;
using NewBlazorProject.Shared.Models.HR_Data;

namespace NewBlazorProject.Server.Services
{
    public class HRService : IHRInterface
    {
        private readonly ApplicationDbContext _context;
            public HRService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<HR_Catagory> AddHR_Catagory(HR_Catagory hR_Catagory)
        {
            var result = await _context.hR_Catagorys.AddAsync(hR_Catagory);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<HR_Clearance> AddHR_Clearance(HR_Clearance hR_Clearance)
        {
            var result = await _context.hR_Clearances.AddAsync(hR_Clearance);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<HR_Designation> AddHR_Designation(HR_Designation hR_Designation)
        {
            var result = await _context.hR_Designations.AddAsync(hR_Designation);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<HR_Posting> AddHR_Posting(HR_Posting hR_Posting)
        {
            var result = await _context.hR_Postings.AddAsync(hR_Posting);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteHR_Catagory(int CatagoryId)
        {
            var result = await _context.hR_Catagorys
                .FirstOrDefaultAsync(e => e.Id == CatagoryId);
            if (result != null)
            {
                _context.hR_Catagorys.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteHR_Clearance(int ClearanceId)
        {
            var result = await _context.hR_Clearances
                .FirstOrDefaultAsync(e => e.id == ClearanceId);
            if (result != null)
            {
                _context.hR_Clearances.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteHR_Designation(int DesignationId)
        {
            var result = await _context.hR_Designations
                .FirstOrDefaultAsync(e => e.Id == DesignationId);
            if (result != null)
            {
                _context.hR_Designations.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteHR_PostingsById(int PostingId)
        {
            var result = await _context.hR_Postings
                .FirstOrDefaultAsync(e => e.Id == PostingId);
            if (result != null)
            {
                _context.hR_Postings.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<HR_Catagory>> GetAllHR_Catagory()
        {
            return await _context.hR_Catagorys.ToListAsync();
        }

        public async Task<IEnumerable<HR_Clearance>> GetAllHR_Clearacne()
        {
            return await _context.hR_Clearances.ToListAsync();
        }

        public async Task<IEnumerable<HR_Designation>> GetAllHR_Designation()
        {
            return await _context.hR_Designations.ToListAsync();
        }

        public async Task<IEnumerable<HR_Posting>> GetAllHR_Posting()
        {
            return await _context.hR_Postings.ToListAsync();
        }

        public async Task<HR_Catagory?> GetHR_CatagoryById(int CatagoryId)
        {
            return await _context.hR_Catagorys.FirstOrDefaultAsync(e => e.Id == CatagoryId);
        }

        public async Task<HR_Clearance> GetHR_ClearanceById(int ClearanceId)
        {
            return await _context.hR_Clearances.FirstOrDefaultAsync(e => e.id == ClearanceId);
        }

        public async Task<HR_Designation> GetHR_DesignationById(int DesignationId)
        {
            return await _context.hR_Designations.FirstOrDefaultAsync(e => e.Id == DesignationId);
        }

        public async Task<HR_Posting> GetHR_PostingById(int postingId)
        {
            return await _context.hR_Postings.FirstOrDefaultAsync(e => e.Id == postingId);
        }

        public async Task<HR_Catagory?> UpdateHR_Catagory(HR_Catagory hR_Catagory)
        {
            var result = await _context.hR_Catagorys.FirstOrDefaultAsync(e => e.Id == hR_Catagory.Id);
            if(result != null)
            {
                result.Name = hR_Catagory.Name;
                result.IsActive = hR_Catagory.IsActive;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task <HR_Clearance?> UpdateHR_Clearance(HR_Clearance hR_Clearance)
        {
            var result = await _context.hR_Clearances.FirstOrDefaultAsync(e => e.id == hR_Clearance.id);
            if (result != null)
            {
                result.ProfileId = hR_Clearance.ProfileId;
                result.Status = hR_Clearance.Status;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
            
        }

        public async Task<HR_Designation?> UpdateHR_Designation(HR_Designation hR_Designation)
        {
            var result = await _context.hR_Designations.FirstOrDefaultAsync(e => e.Id == hR_Designation.Id);
            if (result != null)
            {
                result.Name = hR_Designation.Name;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<HR_Posting?> UpdateHR_Posting(HR_Posting hR_Posting)
        {
            var result = await _context.hR_Postings.FirstOrDefaultAsync(e => e.Id == hR_Posting.Id);
            if (result != null)
            {
                result.Name = hR_Posting.Name;
                result.PostingArea = hR_Posting.PostingArea;
                result.ServiceDuration = hR_Posting.ServiceDuration;
                result.StillEmployee = hR_Posting.StillEmployee;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
