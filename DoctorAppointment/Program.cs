using DoctorAppointment.Utility;
using DoctorAppointment.DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using DataAccess.Repository.IRepository;
using DataAccess.Repository;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DoctorAppointmentDb>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DoctorAppointmentDb") ?? throw new InvalidOperationException("Connection string 'DoctorAppointmentDb' not found.")));
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddScoped<IAdminRepository, AdminRepositoryEf>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DoctorAppointmentDb>().AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(options =>
{
	options.LoginPath = $"/Identity/Account/Login";
	options.LogoutPath = $"/Identity/Account/Logout";
	options.AccessDeniedPath = $"/Identity/Account/AccessDenied";

});

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

//builder.Services.AddKendo();
// Add services to the container.

// Register Kendo services
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
