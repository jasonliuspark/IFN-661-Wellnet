using System;
using Xamarin.Forms;
using SQLite;

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
			SQLiteConnection db = DependencyService.Get<ISQLite>().GetConnection();
			db.CreateTable<PatientDetails> ();
			db.CreateTable<PatientDrugHistry> ();
			db.CreateTable<PatientLocation> ();
			db.CreateTable<PatientMedicalRecord> ();
			db.CreateTable<PatientMonitoringStatus> ();
		}
	
	}
}

