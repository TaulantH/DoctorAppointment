using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Utility
{
    public class EmailSender : IEmailSender
    {
		public void Send(string from, string to, string subject, string messageText)
		{
			throw new NotImplementedException();
		}

		public void Send(MailMessage message)
		{
			throw new NotImplementedException();
		}

		public void Send(IEnumerable<MailMessage> messages)
		{
			throw new NotImplementedException();
		}

		public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
