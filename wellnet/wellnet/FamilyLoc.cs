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
    public class FamilyLoc
    {

        public const string familyPage = "FamilyPage";
        public FamilyLoc ()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<FamilyPageViewModel>();
        }

        public FamilyPageViewModel FamilyPage
        {
            get { return ServiceLocator.Current.GetInstance<FamilyPageViewModel>(); }
        }

    }
}
