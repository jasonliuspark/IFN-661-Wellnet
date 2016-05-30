using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using wellnet;
using wellnet.ViewModels.PatientViewModels;


namespace wellnet
{
    public class PatientLoc
    {
        public const string ptMoodPage = "PatientMoodPage";
        public const string ptActivitiesPage = "PatientActivitiesPage";
        public const string ptMedicationPage = "PatientMedicationPage";

        public PatientLoc()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

           
            SimpleIoc.Default.Register<ViewModels.PatientViewModels.PatientActivitiesPageViewModel>();

            SimpleIoc.Default.Register<PatientListPageViewModel>();
            SimpleIoc.Default.Register<PatientMoodPageViewModel>();
        }

        public PatientMoodPageViewModel PatientMood
        {
            get { return ServiceLocator.Current.GetInstance<PatientMoodPageViewModel>(); }
        }

        public ViewModels.PatientViewModels.PatientActivitiesPageViewModel PatientActivities
        {
            get { return ServiceLocator.Current.GetInstance<ViewModels.PatientViewModels.PatientActivitiesPageViewModel>(); }
        }


    }
}
