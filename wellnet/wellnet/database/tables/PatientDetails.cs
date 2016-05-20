using System;
using SQLite;

namespace wellnet
{
//	public class PatientDetails
//	{
//		[PrimaryKey,AutoIncrement]
//		public int PtID { get; set;}
//		public string FirstName { get; set;}
//		public string LastName { get; set;}
//		public int Age{ get; set;}
//		public string DOB{ get; set;}
//		public string Gender{get;set;}
//		public string AdmissionTime{ get; set;}
//		public int ContactNumber{ get; set;}
//		public string Address {get;set;}
//		public string MedicareNum { get; set;}
//		public string MedicareExpiry { get; set;}
//        public string Status { get; set; }
//	}

	public class PatientDetails
	{
		[PrimaryKey,AutoIncrement]
		public int PtID { get; set;}
		public string FirstName { get; set;}
		public string LastName { get; set;}
		public int Age{ get; set;}
		public string DOB{ get; set;}
		public string Gender{get;set;}
		public string AdmissionTime{ get; set;}
		public int ContactNumber{ get; set;}
		public string Address {get;set;}
		public string MedicareNum { get; set;}
		public string MedicareExpiry { get; set;}
		public string Status { get; set; }
		public int HeartRate { get; set;}
		public int Temperature {get;set;}
		public int BloodPressureHigh { get; set;}
		public int BloodPressureLow { get; set;}
		public int ECGRefference { get; set;}
	}
}

