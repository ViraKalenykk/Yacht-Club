using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yacht__club
{
	public class Participant
	{
		public string FullName { get; set; }
		public DateTime BirthDate { get; set; }
		public string Gender { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }

		public Participant() { }

		public Participant(string fullName, DateTime birthDate, string gender, string phoneNumber, string email)
		{
			FullName = fullName;
			BirthDate = birthDate;
			Gender = gender;
			PhoneNumber = phoneNumber;
			Email = email;
		}
	}
}
