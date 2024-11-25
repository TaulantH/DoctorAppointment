using DoctorAppointment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DoctorAppointment.Data
{
	public class DoctorAppointmentDb : IdentityDbContext<IdentityUser>
	{
		public DoctorAppointmentDb(DbContextOptions<DoctorAppointmentDb> options)
			: base(options) { }

		public DbSet<Appointment> Appointment { get; set; }
		public DbSet<Doctor> Doctor { get; set; }
		public DbSet<Users> Users { get; set; }
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }

	}
}
