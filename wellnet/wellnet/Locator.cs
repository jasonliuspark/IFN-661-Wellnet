using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using wellnet;


namespace wellnet
{
	public class Locator
	{
		public const string MenuPage = "StartupMenu";
		public const string DocPage = "PatientListPage";
		public const string FamilyPage = "FamilyPage";
		public const string PatientPage = "PatientPage";

		public Locator ()
		{
			
			ServiceLocator.SetLocatorProvider (()=>SimpleIoc.Default);
			//register view model

			SimpleIoc.Default.Register<StartupMenuViewModel> ();
			//SimpleIoc.Default.Register<PatientListPageViewModel> ();
		}


		public StartupMenuViewModel startmenu
		{
			get{return ServiceLocator.Current.GetInstance<StartupMenuViewModel> (); }
		}

//		public PatientListPageViewModel ptlist
//		{
//
//			get{ return ServiceLocator.Current.GetInstance<PatientListPageViewModel> ();}
//
//		}
////		
	}
}

