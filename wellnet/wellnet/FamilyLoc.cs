using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using wellnet;
using wellnet.ViewModels.FamilyViewModels;

namespace wellnet
{
    public class FamilyLoc
    {

        public const string familyPage = "FamilyPage";
        public const string familyMedication = "FamilyMedication";
        public const string familyVitalsPage = "FamilyVitalsPage";
        public const string familyAgendaPage = "FamilyAgendaPage";

        public FamilyLoc()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<FamilyPageViewModel>();
            SimpleIoc.Default.Register<FamilyMedicationViewModel>();
            SimpleIoc.Default.Register<FamilyVitalsPageViewModel>();
            SimpleIoc.Default.Register<FamilyAgendaPageViewModel>();
        }

        public FamilyPageViewModel FamilyPage
        {
            get { return ServiceLocator.Current.GetInstance<FamilyPageViewModel>(); }
        }
        public FamilyMedicationViewModel FamilyMedication1
        {
            get { return ServiceLocator.Current.GetInstance<FamilyMedicationViewModel>(); }
        }

        public FamilyVitalsPageViewModel FamilyVitals
        {
            get { return ServiceLocator.Current.GetInstance<FamilyVitalsPageViewModel>(); }
        }

        public FamilyAgendaPageViewModel FamilyAgenda
        {
            get { return ServiceLocator.Current.GetInstance<FamilyAgendaPageViewModel>(); }
        }


    }
}