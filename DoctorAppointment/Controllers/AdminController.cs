using DoctorAppointment.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.Controllers
{
	public class AdminController : Controller
	{
		private readonly DoctorAppointmentDb _context;
		public AdminController(DoctorAppointmentDb context)
		{
			_context = context;
		}
		// Ensure the role name matches your application setup

		public IActionResult Dashboard()
		{
			
			return View();
		}
	}
}