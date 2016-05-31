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

        //public const string familyMessagesPage = "FamilyMessagesPage";
        public const string patientMoodPage = "PatientMoodPage";
        public const string patientActivitiesPage = "PatientActivitiesPage";
        public const string patientMedicationPage = "PatientMedicationPage";
        public const string patientMoodsPage = "PatientMoodsPage";

        public PatientLoc()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

          //SimpleIoc.Default.Register<FamilyMessagesPageViewModel>();
            SimpleIoc.Default.Register<PatientActivitiesPageViewModel>();
            SimpleIoc.Default.Register<PatientMoodsPageViewModel>();
            SimpleIoc.Default.Register<PatientMedicationPageViewModel>();

            SimpleIoc.Default.Register<PatientListPageViewModel>();
            SimpleIoc.Default.Register<PatientMoodPageViewModel>();
        }

        public PatientMoodPageViewModel PatientMood
        {
            get { return ServiceLocator.Current.GetInstance<PatientMoodPageViewModel>(); }
        }

        public PatientActivitiesPageViewModel PatientActivities
        {
            get { return ServiceLocator.Current.GetInstance<PatientActivitiesPageViewModel>(); }
        }

        public PatientMoodsPageViewModel PatientsMoods
        {
            get { return ServiceLocator.Current.GetInstance<PatientMoodsPageViewModel>(); }
        }

        public PatientMedicationPageViewModel PatientMedication
        {
            get { return ServiceLocator.Current.GetInstance<PatientMedicationPageViewModel>(); }
        }
    }
}
