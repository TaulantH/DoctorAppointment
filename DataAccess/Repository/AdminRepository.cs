using Dapper;
using DataAccess.Repository.IRepository;
using DoctorAppointment.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccess.Repository
{
	public class AdminRepository : IAdminRepository
	{
		private IDbConnection _connection;

		public AdminRepository(IConfiguration configuration) 
		{
			this._connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
		}

		public Doctor Add(Doctor doctor) {
			var sql = "Insert INTO Doctor(DoctorName, Specialization) VALUES(@DoctorName, @Specialization);";
			var id = _connection.Query<int>(sql, doctor).Single();
			doctor.DoctorId = id;
			return doctor;
		}

		public Doctor Find(int id)
		{
			var sql = "SELECT * FROM Doctor WHERE DoctorId = @DoctorId";  // Correct parameter name
			return _connection.Query<Doctor>(sql, new { DoctorId = id }).Single();  // Corrected parameter name
		}


		public List<Doctor> GetAll()
		{
			var sql = "SELECT * FROM Doctor";
			return _connection.Query<Doctor>(sql).ToList();
		}

		public void Remove(int id)
		{
			var sql = "SELECT * FROM Doctors WHERE DoctorId = @id";
			_connection.Execute(sql, new { id });
		}


		public Doctor Update(Doctor doctor)
		{
			var sql = "UPDATE Doctor SET DoctorName = @DoctorName, Specialization = @Specialization";
			_connection.Execute(sql, doctor);
			return doctor;
		}
	}
}
