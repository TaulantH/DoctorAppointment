using DoctorAppointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
	public interface IAdminRepository
	{
		Doctor Find(int id);
		List<Doctor> GetAll();
		Doctor Add(Doctor doctor);
		Doctor Update(Doctor doctor);
		void Remove(int id);
	}
}
