using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NewBlazorProject.Server.Models;
using NewBlazorProject.Shared.Models;
using NewBlazorProject.Shared.Models.HR_Data;
using NewBlazorProject.Shared.Models.MasterData;



namespace NewBlazorProject.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "User", NormalizedName = "USER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
        }

        public DbSet<MD_District> MD_Districts { get; set; }
        public DbSet<MD_Tehsil> MD_Tehsils { get; set; }
        public DbSet<MD_CreatedBy> MD_CreatedBy { get; set; }
        public DbSet<MD_Gender> MD_Genders { get; set; }
        public DbSet<MD_UpdatedBy> MD_UpdatedBys { get; set; }
        public DbSet<MD_Address> MD_Addresses { get; set; }
        public DbSet<MD_UploadFile> MD_UploadFiles { get; set; }
        public DbSet<MD_Directory> MD_Directories { get; set; }
        public DbSet<MD_Education> MD_Educations { get; set; }
        public DbSet<MD_EducationLevel> MD_EducationLevels { get; set; }

        public DbSet<HR_Clearance> hR_Clearances { get; set; }
        public DbSet<HR_Designation>hR_Designations { get; set; }
        public DbSet<HR_Posting> hR_Postings { get; set; }
        public DbSet<HR_Catagory> hR_Catagorys { get; set; }

       public DbSet<Profile> Profiles { get; set; }
    }
}