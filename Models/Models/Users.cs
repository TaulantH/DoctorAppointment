﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Models
{
	public class Users : IdentityUser
	{
	
			[Required]
			public string Name { get; set; }
			public string? StreetAddress { get; set; }
			public string? City { get; set; }
			public string? State { get; set; }
			public string? PostalCode { get; set; }
	}
}
