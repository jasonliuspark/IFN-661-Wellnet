using System;
using SQLite;

namespace wellnet
{
	public class PatientLocation
	{
		[PrimaryKey]
		public int PtID { get; set;}
		public double x_coordinate { get; set;}
		public double y_coordinate { get; set;}

	}
}

