using Microsoft.AspNetCore.Identity;

namespace DoctorAppointment.Models
{
	public class Doctor : IdentityUser
	{
		public int DoctorId { get; set; }
		public string DoctorName { get; set; }
		public string Specialization { get; set; }


	}
}
