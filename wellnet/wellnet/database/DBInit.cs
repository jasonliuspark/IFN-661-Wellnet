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
			//PationMonitoringInit (db);
		}

		
		public void PatientDetailsInit(SQLiteConnection db)
		{
			
//			SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();

			//Jack testing combined table (PatientDetails and PatientMonitoringStatus)
			if (db.Table<PatientDetails> ().Count () > 0) {
				db.DropTable<PatientDetails> ();
				db.CreateTable <PatientDetails> ();
			} else {
				db.CreateTable <PatientDetails> ();
			}

			// db.CreateTable<PatientDetails> ();
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
				NewPtDetails.BloodPressureHigh = 120;
				NewPtDetails.BloodPressureLow = 80;
				NewPtDetails.ECGRefference = 5;
				NewPtDetails.HeartRate = 70;
				NewPtDetails.PtID = 0;
				NewPtDetails.Temperature = 36;
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
				NewPtDetails2.BloodPressureHigh = 117;
				NewPtDetails2.BloodPressureLow = 63;
				NewPtDetails2.ECGRefference = 4;
				NewPtDetails2.HeartRate = 91;
				NewPtDetails2.PtID = 1;
				NewPtDetails2.Temperature = 37;
                db.Insert(NewPtDetails2);

				var NewPtDetails3 = new PatientDetails();
				NewPtDetails3.FirstName = "Kelly";
				NewPtDetails3.LastName = "Watson";
				NewPtDetails3.Address = "1 Orange street 4109 QLD";
				NewPtDetails3.Age = 27;
				NewPtDetails3.DOB = "12/04/1989";
				NewPtDetails3.ContactNumber = 0434105253;
				NewPtDetails3.AdmissionTime = "16/04/2015";
				NewPtDetails3.Gender = "female";
				NewPtDetails3.MedicareExpiry = "15/05/2018";
				NewPtDetails3.MedicareNum = "0199938330921";
				NewPtDetails3.Status = "normal";
				NewPtDetails3.BloodPressureHigh = 112;
				NewPtDetails3.BloodPressureLow = 61;
				NewPtDetails3.ECGRefference = 4;
				NewPtDetails3.HeartRate = 80;
				NewPtDetails3.PtID = 2;
				NewPtDetails3.Temperature = 37;
				db.Insert(NewPtDetails3);

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

//		public void PationMonitoringInit(SQLiteConnection db)
//		{
//			SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();
//						db.CreateTable<PatientMonitoringStatus> ();
//						if (db.Table<PatientMonitoringStatus> ().Count () == 0) {
//							var NewStatus = new PatientMonitoringStatus ();
//							NewStatus.BloodPressureHigh = 120;
//							NewStatus.BloodPressureLow = 80;
//							NewStatus.ECGRefference = 5;
//							NewStatus.HeartRate = 70;
//							NewStatus.PtID = 0;
//						    NewStatus.Temperature = 36;
//			              NewStatus.Status = "Normal";
//							db.Insert (NewStatus);
//			              var NewStatus2 = new PatientMonitoringStatus();
//			              NewStatus2.BloodPressureHigh = 110;
//			              NewStatus2.BloodPressureLow = 90;
//			              NewStatus2.ECGRefference = 5;
//			              NewStatus2.HeartRate = 80;
//			              NewStatus2.PtID = 1;
//			              NewStatus2.Temperature = 37;
//			              NewStatus2.Status = "Normal";
//			              db.Insert(NewStatus2);
//            }
//		}


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
		//        public IEnumerable<PatientMonitoringStatus> GetStatus()
		//        {
		//            
		//            return (from t in db.Table<PatientMonitoringStatus>() select t).ToList();
		//
		//        }
        //todo: join table

    }
}

