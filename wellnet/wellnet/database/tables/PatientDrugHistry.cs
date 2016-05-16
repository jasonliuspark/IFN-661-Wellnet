using System;
using SQLite;

namespace wellnet
{
	public class PatientDrugHistry
	{
		[PrimaryKey,AutoIncrement]
		public int DrugID{ get; set;}
		public int PtID{ get; set;}
		public string Strength { get; set;}
		public string Dosage { get; set;}
		public string DosingTime{get;set;}
	}
}

