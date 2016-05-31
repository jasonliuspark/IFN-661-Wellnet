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
			//PatientDrugHistoryInit (db);
			//PatientMedicalRecordInit (db);
			//PationLocationInit (db);
			//PationMonitoringInit (db);
		}

		public IEnumerable<PatientDetails> GetDetails()
		{
		    
			return (from t in db.Table<PatientDetails>() select t).ToList();
		
		}

        //		public IEnumerable<PatientMonitoringStatus> GetStatus()
        //
        //        {
        //           
        //			return (from t in db.Table<PatientMonitoringStatus>() select t).ToList();
        //			
        //		}
        //



        public void PatientDetailsInit(SQLiteConnection db)
        {

            //SQLiteConnection db = DependencyService.Get<ISQLite> ().GetConnection ();

            if (db.Table<PatientDetails>().Count() != 0)
            {
                db.DropTable<PatientDetails>();
                db.CreateTable<PatientDetails>();
                var NewPtDetails = new PatientDetails();
                NewPtDetails.PtID = 0;
                NewPtDetails.FirstName = "Doris";
                NewPtDetails.LastName = "Morrison";
                NewPtDetails.Age = 25;
                NewPtDetails.DOB = "12/04/1991";
                NewPtDetails.Gender = "Female";
                NewPtDetails.AdmissionTime = "13/04/2015";
                NewPtDetails.ContactNumber = 0434105253;
                NewPtDetails.Address = "1 Apple street 4000 QLD";
                NewPtDetails.MedicareNum = "0199938374747";
                NewPtDetails.MedicareExpiry = "13/05/2018";
                //testing, should be in monitoring status table
                NewPtDetails.HeartRate = 96;
                NewPtDetails.Temp = 36.8;
                NewPtDetails.BloodPressureHigh = 120;
                NewPtDetails.BloodPressureLow = 81;
                NewPtDetails.ECGRefference = 5;
                NewPtDetails.ECGPic = "John_ecg.gif";
                NewPtDetails.RoomNo = "C-HTA-406";
                NewPtDetails.Location = "John_location.jpg";
				NewPtDetails.PtImage = "Doris_Morrison.png";
                NewPtDetails.Status = "Normal";
                //testing, should be in drugHistry table
                NewPtDetails.DrugName = "Panadol";
                NewPtDetails.Dosage = "1 pill";
                NewPtDetails.DosingTime = "2/day";
                NewPtDetails.Strength = "weak";
                //testing, should be in MedicalRecord table
                NewPtDetails.DoctorNotes = "currently in good health";
                NewPtDetails.PastDisease = "athsma";
                NewPtDetails.PtMood = "Stable";

                db.Insert(NewPtDetails);

                var NewPtDetails2 = new PatientDetails();
                NewPtDetails2.PtID = 1;
                NewPtDetails2.FirstName = "Pete";
                NewPtDetails2.LastName = "Dray";
                NewPtDetails2.Age = 70;
                NewPtDetails2.DOB = "12/04/1946";
                NewPtDetails2.Gender = "Male";
                NewPtDetails2.AdmissionTime = "13/04/2015";
                NewPtDetails2.ContactNumber = 0434105253;
                NewPtDetails2.Address = "1 Apple street 4000 QLD";
                NewPtDetails2.MedicareNum = "0199938370989";
                NewPtDetails2.MedicareExpiry = "13/05/2018";
                //testing, should be in monitoring status table
                NewPtDetails2.HeartRate = 71;
                NewPtDetails2.Temp = 37.1;
                NewPtDetails2.BloodPressureHigh = 110;
                NewPtDetails2.BloodPressureLow = 61;
                NewPtDetails2.ECGRefference = 5;
                NewPtDetails2.ECGPic = "John_ecg.gif";
                NewPtDetails2.RoomNo = "C-HTA-409";
                NewPtDetails2.Location = "Doris_location.jpg";
				NewPtDetails2.PtImage = "Pete_Dray.png";
                NewPtDetails2.Status = "Normal";
                //testing, should be in drugHistry table
                NewPtDetails2.DrugName = "Razadyne";
                NewPtDetails2.Dosage = "500mg";
                NewPtDetails2.DosingTime = "a.m.";
                NewPtDetails2.Strength = "weak";
                //testing, should be in MedicalRecord table
                NewPtDetails2.DoctorNotes = "take more care of heart";
                NewPtDetails2.PastDisease = "premature";
                //testing, patient mood
                NewPtDetails2.PtMood = "Happy";
                db.Insert(NewPtDetails2);


				var NewPtDetails3 = new PatientDetails();
				NewPtDetails3.PtID = 2;
				NewPtDetails3.FirstName = "Jean";
				NewPtDetails3.LastName = "Paul";
				NewPtDetails3.Age = 71;
				NewPtDetails3.DOB = "12/04/1946";
				NewPtDetails3.Gender = "Male";
				NewPtDetails3.AdmissionTime = "13/04/2015";
				NewPtDetails3.ContactNumber = 0434105253;
				NewPtDetails3.Address = "1 Apple street 4000 QLD";
				NewPtDetails3.MedicareNum = "0199938370989";
				NewPtDetails3.MedicareExpiry = "13/05/2018";
				//testing, should be in monitoring status table
				NewPtDetails3.HeartRate = 82;
				NewPtDetails3.Temp = 36.7;
				NewPtDetails3.BloodPressureHigh = 121;
				NewPtDetails3.BloodPressureLow = 78;
				NewPtDetails3.ECGRefference = 5;
				NewPtDetails3.ECGPic = "John_ecg.gif";
				NewPtDetails3.RoomNo = "C-HTA-401";
				NewPtDetails3.Location = "Doris_location.jpg";
				NewPtDetails3.PtImage = "Jean_Paul.png";
				NewPtDetails3.Status = "Normal";
				//testing, should be in drugHistry table
				NewPtDetails3.DrugName = "Razadyne";
				NewPtDetails3.Dosage = "500mg";
				NewPtDetails3.DosingTime = "a.m.";
				NewPtDetails3.Strength = "weak";
				//testing, should be in MedicalRecord table
				NewPtDetails3.DoctorNotes = "take more care of heart";
				NewPtDetails3.PastDisease = "premature";
				//testing, patient mood
				NewPtDetails3.PtMood = "Stable";
				db.Insert(NewPtDetails3);

				var NewPtDetails4 = new PatientDetails();
				NewPtDetails4.PtID = 3;
				NewPtDetails4.FirstName = "Bird";
				NewPtDetails4.LastName = "Johnson";
				NewPtDetails4.Age = 52;
				NewPtDetails4.DOB = "12/04/1966";
				NewPtDetails4.Gender = "Feale";
				NewPtDetails4.AdmissionTime = "13/04/2015";
				NewPtDetails4.ContactNumber = 0434105253;
				NewPtDetails4.Address = "1 Apple street 4000 QLD";
				NewPtDetails4.MedicareNum = "0199938370989";
				NewPtDetails4.MedicareExpiry = "13/05/2018";
				//testing, should be in monitoring status table
				NewPtDetails4.HeartRate = 67;
				NewPtDetails4.Temp = 37.1;
				NewPtDetails4.BloodPressureHigh = 115;
				NewPtDetails4.BloodPressureLow = 73;
				NewPtDetails4.ECGRefference = 5;
				NewPtDetails4.ECGPic = "John_ecg.gif";
				NewPtDetails4.RoomNo = "C-HTA-402";
				NewPtDetails4.Location = "Doris_location.jpg";
				NewPtDetails4.PtImage = "Bird_Johnson.png";
				NewPtDetails4.Status = "Normal";
				//testing, should be in drugHistry table
				NewPtDetails4.DrugName = "Razadyne";
				NewPtDetails4.Dosage = "500mg";
				NewPtDetails4.DosingTime = "a.m.";
				NewPtDetails4.Strength = "weak";
				//testing, should be in MedicalRecord table
				NewPtDetails4.DoctorNotes = "take more care of heart";
				NewPtDetails4.PastDisease = "premature";
				//testing, patient mood
				NewPtDetails4.PtMood = "Happy";
				db.Insert(NewPtDetails4);
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
				db.Insert (NewStatus);
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
	}
}

