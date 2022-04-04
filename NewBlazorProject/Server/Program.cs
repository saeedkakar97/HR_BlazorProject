using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Duende.IdentityServer.Services;
using NewBlazorProject.Server.Data;
using NewBlazorProject.Server.Models;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using NewBlazorProject.Server.InterFaces;
using NewBlazorProject.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
/*builder.Services.AddDbContext<NewBlazorProjectServerContext>(options =>
    options.UseSqlServer(connectionString));*/
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentityServer()
    .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options => {
        options.IdentityResources["openid"].UserClaims.Add("name");
        options.ApiResources.Single().UserClaims.Add("name");
        options.IdentityResources["openid"].UserClaims.Add("role");
        options.ApiResources.Single().UserClaims.Add("role");
    });
JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Remove("role");

//builder.Services.AddTransient<IProfileService, ProfileService>();
builder.Services.AddScoped<IAdminInterface, AdminService>();
builder.Services.AddScoped<IHRInterface, HRService>();
builder.Services.AddScoped<ICustomerInterface, CustomerService>();

builder.Services.AddAuthentication()
    .AddIdentityServerJwt();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();
app.UseAuthentication();
app.UseAuthorization();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
