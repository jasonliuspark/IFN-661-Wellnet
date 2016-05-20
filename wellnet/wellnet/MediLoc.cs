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
	public class MediLoc
	{
		public const string ptlistPage="PatientListPage";
		public const string detailPage="PatientDetailsPage";
		public const string monitoringPage="PatientMonitoringViewModel";
		public const string tackMapPage="TrackMapPageViewModel";
		public MediLoc ()
		{
			ServiceLocator.SetLocatorProvider (() => SimpleIoc.Default);
			//SimpleIoc.Default.Register<MedicalHistoryPageViewModel> ();
			//SimpleIoc.Default.Register<PatientDetailsPageViewModel> ();
			//SimpleIoc.Default.Register<TrackMapPageViewModel> ();
			SimpleIoc.Default.Register<PatientListPageViewModel> ();
			SimpleIoc.Default.Register<PatientMonitoringViewModel> ();
		}

		public PatientListPageViewModel ptlist
		{
			get{return ServiceLocator.Current.GetInstance<PatientListPageViewModel> ();}
		}
		public PatientMonitoringViewModel monitStatus
		{
			get{return ServiceLocator.Current.GetInstance<PatientMonitoringViewModel> ();}
		}

	}
}

