using System;
using SQLite;

namespace wellnet
{
	public class PatientLocation
	{
		[PrimaryKey]
		public int PtID { get; set;}
		public float x_coordinate { get; set;}
		public float y_coordinate { get; set;}

	}
}

