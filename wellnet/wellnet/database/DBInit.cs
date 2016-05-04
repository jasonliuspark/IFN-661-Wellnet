using System;
using Xamarin.Forms;
using SQLite;
using System.Collections;

using SQLitePCL;

namespace wellnet
{
	public interface ISQLite
    {
		SQLiteConnection GetConnection();

	}
	public class DBInit
	{
		public DBInit ()
		{
			//SQLiteConnection db = DependencyService.Get<ISQLite>().GetConnection();
			//init tables if not existed 
			PatientDetailsInit ();
			PatientDrugHistoryInit ();
			PatientMedicalRecordInit ();
			PationLocationInit ();
			PationMonitoringInit ();
		}
		//Todo dbtest
//		public IEnumerable<PatientDetails> GetDetails()
//		{
//
//			return;
//
//		}
		public void PatientDetailsInit()
		{
			
			SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
			db.CreateTable<PatientDetails> ();
			if (db.Table<PatientDetails> ().Count() == 0) {
			    
				var NewPtDetails = new PatientDetails ();
				NewPtDetails.FirstName = "John";
				NewPtDetails.LastName="Doe";
				NewPtDetails.Address="1 Apple street 4000 QLD";
				NewPtDetails.Age = 25;
				NewPtDetails.DOB="12/04/1991";
				NewPtDetails.ContactNumber = 0434105253;
				NewPtDetails.AdmissionTime="13/04/2015";
				NewPtDetails.Gender="male";
				NewPtDetails.MedicareExpiry = "13/05/2018";
				NewPtDetails.MedicareNum = "0199938374747";
				db.Insert (NewPtDetails);		
			}
		}
		public void PatientDrugHistoryInit()
		{
			SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
			db.CreateTable<PatientDrugHistry> ();
			if (db.Table<PatientDrugHistry> ().Count() == 0) {
				var NewDrgHistory = new PatientDrugHistry ();
				NewDrgHistory.Dosage="50mg";
				NewDrgHistory.DosingTime="2/day";
				NewDrgHistory.PtID = 0;
				NewDrgHistory.Strength = "weak";
				db.Insert (NewDrgHistory);
			}
				
		}
		public void PationLocationInit()
		{
			SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
			db.CreateTable<PatientLocation> ();
			if (db.Table<PatientLocation> ().Count () == 0) {
				var NewLocation = new PatientLocation ();
				NewLocation.x_coordinate = 40.05;
				NewLocation.y_coordinate = 50.05;
				NewLocation.PtID = 0;
				db.Insert (NewLocation);	
			}

		}
		public void PationMonitoringInit()
		{
			SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
			db.CreateTable<PatientMonitoringStatus> ();
			if (db.Table<PatientMonitoringStatus> ().Count () == 0) {
				var NewStatus = new PatientMonitoringStatus ();
				NewStatus.BloodPressureHigh = 120;
				NewStatus.BloodPressureLow = 80;
				NewStatus.ECGRefference = 5;
				NewStatus.HeartRate = 70;
				NewStatus.PtID = 0;
				db.Insert (NewStatus);
			}
		}
		public void PatientMedicalRecordInit()
		{
			SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
			db.CreateTable<PatientMedicalRecord> ();
			if (db.Table<PatientMedicalRecord> ().Count () == 0) {
				var NewRecord = new PatientMedicalRecord ();
				NewRecord.DoctorNotes = "currently in good health";
				NewRecord.PastDisease = "athsma";
				NewRecord.PtID = 0;
				db.Insert (NewRecord);	
			}
		}
	}
}

