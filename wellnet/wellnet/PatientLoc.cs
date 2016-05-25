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

        public PatientLoc ()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
			SimpleIoc.Default.Register<PatientListPageViewModel> ();
            SimpleIoc.Default.Register<PatientMoodPageViewModel>();
        }

        public PatientMoodPageViewModel PatientMood
        {
            get { return ServiceLocator.Current.GetInstance<PatientMoodPageViewModel>(); }
        }

    }
}
