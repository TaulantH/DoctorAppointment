using DataAccess.Repository.IRepository;
using DoctorAppointment.DataAccess.Data;
using DoctorAppointment.Models;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DoctorAppointment.Controllers
{
	public class AdminController : Controller
	{
		private readonly IAdminRepository _adminRepository;
		public AdminController(IAdminRepository adminRepository)
		{
			_adminRepository = adminRepository;
		}
		// Ensure the role name matches your application setup

		public async Task<IActionResult> Dashboard()
		{
			return View(_adminRepository.GetAll());
		}
		public IActionResult Create()
		{
			return View();

		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("DoctorId,DoctorName,Specialization")] Doctor doctor)
		{
			if (ModelState.IsValid)
			{
				_adminRepository.Add(doctor);
				return RedirectToAction(nameof(Dashboard));
			}
			return View(doctor);
		}

	}
}