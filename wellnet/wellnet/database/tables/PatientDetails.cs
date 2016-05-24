using System;
using SQLite;

namespace wellnet
{
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
		//Monitoring status table
		public int HeartRate { get; set;}
		public double Temp { get; set;}
		public int BloodPressureHigh { get; set;}
		public int BloodPressureLow { get; set;}
		public int ECGRefference { get; set;}
		public string ECGPic { get; set;}
		public string RoomNo { get; set;}
		public string Location { get; set;}
		public string Status { get; set;}
		// DrugHistry table
		public string DrugName { get; set;}
		public string Dosage { get; set;}
		public string DosingTime { get; set;}
		public string Strength { get; set;}
		//MedicalRecord table
		public string DoctorNotes { get; set;}
		public string PastDisease{ get; set;}
	}
}

