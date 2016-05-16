using System;
using Xamarin.Forms;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using SQLitePCL;

namespace wellnet
{
	
	public class DBInit
	{
		public SQLiteConnection db;

		public DBInit ()
		{
			db = DependencyService.Get<ISQLite>().GetConnection();

			//init tables if not existed 
			PatientDetailsInit (db);
			PatientDrugHistoryInit (db);
			PatientMedicalRecordInit (db);
			PationLocationInit (db);
			PationMonitoringInit (db);
		}

		
		public void PatientDetailsInit(SQLiteConnection db)
		{
			
//			SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
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
                NewPtDetails.Status = "normal";
				db.Insert (NewPtDetails);
                var NewPtDetails2 = new PatientDetails();
                NewPtDetails2.FirstName = "Jane";
                NewPtDetails2.LastName = "Dole";
                NewPtDetails2.Address = "1 Banana street 4109 QLD";
                NewPtDetails2.Age = 23;
                NewPtDetails2.DOB = "12/04/1991";
                NewPtDetails2.ContactNumber = 0434105253;
                NewPtDetails2.AdmissionTime = "13/04/2015";
                NewPtDetails2.Gender = "male";
                NewPtDetails2.MedicareExpiry = "13/05/2018";
                NewPtDetails2.MedicareNum = "0199938374747";
                NewPtDetails2.Status = "normal";
                db.Insert(NewPtDetails2);
            }
		}
		public void PatientDrugHistoryInit(SQLiteConnection db)
		{
			//SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
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
		public void PationLocationInit(SQLiteConnection db)
		{
			//SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
			db.CreateTable<PatientLocation> ();
			if (db.Table<PatientLocation> ().Count () == 0) {
				var NewLocation = new PatientLocation ();
				NewLocation.x_coordinate = 40.05;
				NewLocation.y_coordinate = 50.05;
				NewLocation.PtID = 0;
				db.Insert (NewLocation);	
			}

		}
		public void PationMonitoringInit(SQLiteConnection db)
		{
			//SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
			db.CreateTable<PatientMonitoringStatus> ();
			if (db.Table<PatientMonitoringStatus> ().Count () == 0) {
				var NewStatus = new PatientMonitoringStatus ();
				NewStatus.BloodPressureHigh = 120;
				NewStatus.BloodPressureLow = 80;
				NewStatus.ECGRefference = 5;
				NewStatus.HeartRate = 70;
				NewStatus.PtID = 0;
                NewStatus.Temperature = 36;
                NewStatus.Status = "Normal";
				db.Insert (NewStatus);
                var NewStatus2 = new PatientMonitoringStatus();
                NewStatus2.BloodPressureHigh = 110;
                NewStatus2.BloodPressureLow = 90;
                NewStatus2.ECGRefference = 5;
                NewStatus2.HeartRate = 80;
                NewStatus2.PtID = 1;
                NewStatus2.Temperature = 37;
                NewStatus2.Status = "Normal";
                db.Insert(NewStatus2);
            }
		}
		public void PatientMedicalRecordInit(SQLiteConnection db)
		{
			//SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
			db.CreateTable<PatientMedicalRecord> ();
			if (db.Table<PatientMedicalRecord> ().Count () == 0) {
				var NewRecord = new PatientMedicalRecord ();
				NewRecord.DoctorNotes = "currently in good health";
				NewRecord.PastDisease = "athsma";
				NewRecord.PtID = 0;
				db.Insert (NewRecord);	
			}
            
		}
        //queries
        public IEnumerable<PatientDetails> GetDetails()
        {

            return (from t in db.Table<PatientDetails>() select t).ToList();

        }


        /*details and track data join */
        public IEnumerable<PatientMonitoringStatus> GetStatus()
        {
            
            return (from t in db.Table<PatientMonitoringStatus>() select t).ToList();

        }
        //todo: join table

    }
}

