using System;
using SQLite;

namespace wellnet
{
	public class PatientMedicalRecord
	{
		[PrimaryKey]
		public int PtID { get; set;}
		public string PastDisease { get; set;}
		public string DoctorNotes { get; set;}

	}
}

