using System;

using Xamarin.Forms;

namespace wellnet
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new PatientList();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
			DBInit db=new DBInit();

		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

