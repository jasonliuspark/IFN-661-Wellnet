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
    public class PatientLoc
    {
        public const string ptMoodPage = "PatientMoodPage";

        public PatientLoc ()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<ViewModels.PatientViewModels.PatientMoodPageViewModel>();
        }

        public ViewModels.PatientViewModels.PatientMoodPageViewModel PatientMood
        {
            get { return ServiceLocator.Current.GetInstance<ViewModels.PatientViewModels.PatientMoodPageViewModel>(); }
        }

    }
}
