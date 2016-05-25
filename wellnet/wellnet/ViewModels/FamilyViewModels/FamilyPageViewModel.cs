using System;
using Xamarin.Forms;
using GalaSoft.MvvmLight;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace wellnet
{
    public class FamilyPageViewModel : ViewModelBase
    {
        private INavigationService _nav;
        public FamilyPageViewModel(INavigationService nav )
        {

            var db = new DBInit();
            _nav = nav;
            familymedication = new RelayCommand(()=> _nav.NavigateTo(FamilyLoc.familyMedication));
            familyvitals = new RelayCommand(() => _nav.NavigateTo(FamilyLoc.familyVitalsPage));
        }

     public   ICommand familymedication{
            get;
            set;
        }
    public ICommand familyvitals {
            get;
            set;
        }
    }
}
