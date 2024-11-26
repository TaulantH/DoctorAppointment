using DataAccess.Repository.IRepository;
using DoctorAppointment.DataAccess.Data;
using DoctorAppointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
	public class AdminRepositoryEf : IAdminRepository
	{
		private readonly DoctorAppointmentDb _connection;

		public AdminRepositoryEf(DoctorAppointmentDb connection)
		{
			_connection = connection;
		}

		public Doctor Add(Doctor doctor)
		{
			_connection.Doctor.Add(doctor);
			_connection.SaveChanges();
			return doctor;
		}

		public Doctor Find(int id)
		{
			return _connection.Doctor.FirstOrDefault(u => u.DoctorId == id);
		}


		public List<Doctor> GetAll()
		{
			return _connection.Doctor.ToList();
		}

		public void Remove(int id)
		{
			Doctor doctor = _connection.Doctor.FirstOrDefault(u => u.DoctorId==id);
			_connection.Doctor.Remove(doctor);
			_connection.SaveChanges();
			return;
		}



		public Doctor Update(Doctor doctor)
		{
			_connection.Doctor.Update(doctor);
			_connection.SaveChanges();
			return doctor;
		}
	}
}
