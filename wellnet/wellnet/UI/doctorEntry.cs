using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace wellnet
{
	public partial class doctorEntry : TabbedPage
	{
		public doctorEntry ()
		{

			var database = new DBInit();

			Children.Add (
				new NavigationPage (new TrackMapPage () { Title = "TrackMap" }) {
					Title = "Map",
					//Icon = ""
				}
			);

			Children.Add (
				new NavigationPage (new PaitentListPage (database) { Title = "PatientList" }) {
					Title = "Patients",
					//Icon = ""
				}
			);

		}
	}
}

