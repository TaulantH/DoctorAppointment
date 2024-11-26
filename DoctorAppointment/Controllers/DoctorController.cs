using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.Controllers
{
	public class DoctorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
