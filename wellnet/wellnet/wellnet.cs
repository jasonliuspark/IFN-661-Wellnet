using System;

using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using wellnet.Views.FamilyViews;
using wellnet.Views.PatientViews;

namespace wellnet
{
	public class App : Application
	{
		private static Locator _loc;
        
		public static Locator Locator { get { return _loc ?? (_loc = new Locator()); } }
		private static MediLoc _mediloc;
		public static MediLoc MediLoc { get { return _mediloc ?? (_mediloc = new MediLoc()); } }

        private static PatientLoc _patientLoc;
        public static PatientLoc PatientLoc { get { return _patientLoc ?? ( _patientLoc = new PatientLoc()); } }

        private static FamilyLoc _familyLoc;
        public static FamilyLoc FamilyLoc { get { return _familyLoc ?? (_familyLoc = new FamilyLoc()); } }
		public App ()
		{
			// The root page of your application
			//MainPage = new NavigationPage(new PatientMonitoringPage());
			//MainPage=new NavigationPage(new StartupMenu());

			var nav = new NavigationService();
			nav.Configure(Locator.MenuPage, typeof(StartupMenu));
			nav.Configure(MediLoc.ptlistPage, typeof(PatientListPage));

            nav.Configure(PatientLoc.patientMoodPage, typeof(PatientMoodPage));
            nav.Configure(PatientLoc.patientMedicationPage, typeof(PatientMedicationPage));
            nav.Configure(PatientLoc.patientActivitiesPage, typeof(PatientActivitiesPage));
            nav.Configure(PatientLoc.patientMoodsPage, typeof(PatientMoodsPage));

            nav.Configure(FamilyLoc.familyPage, typeof(FamilyPage));
            nav.Configure(FamilyLoc.familyMedication, typeof(FamilyMedication));
            nav.Configure(FamilyLoc.familyVitalsPage, typeof(FamilyVitalsPage));
            nav.Configure(FamilyLoc.familyAgendaPage, typeof(FamilyAgenda));
            nav.Configure(FamilyLoc.familyMessagesPage, typeof(FamilyMessagesPage));
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

