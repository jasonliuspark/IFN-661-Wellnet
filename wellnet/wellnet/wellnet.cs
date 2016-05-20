using System;

using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace wellnet
{
	public class App : Application
	{
		private static Locator _loc;
		public static Locator Locator { get { return _loc ?? (_loc = new Locator()); } }
		private static MediLoc _mediloc;
		public static MediLoc MediLoc { get { return _mediloc ?? (_mediloc = new MediLoc()); } }
		public App ()
		{
			// The root page of your application
			//MainPage = new NavigationPage(new PatientMonitoringPage());
			//MainPage=new NavigationPage(new StartupMenu());

			var nav = new NavigationService();
			nav.Configure(Locator.MenuPage, typeof(StartupMenu));
			nav.Configure(MediLoc.ptlistPage, typeof(PatientListPage));
			//nav.Configure(Locator.ThirdPage, typeof(ThirdPage));
			SimpleIoc.Default.Register<INavigationService>(() => nav);

			var firstPage = new NavigationPage(new StartupMenu());

			nav.Initialize(firstPage);

			//SimpleIoc.Default.Register<INavigationService>(() => nav);

			MainPage = firstPage;

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
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

