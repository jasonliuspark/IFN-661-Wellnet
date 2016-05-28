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


namespace wellnet.ViewModels.PatientViewModels
{
    public class PatientMoodPageViewModel:ViewModelBase
    {
        // private enumerated value for mood

        // random message to show patient from list of random messages


        private INavigationService _nav;
        public PatientMoodPageViewModel(INavigationService nav )
        {
            var db = new DBInit();
            _nav = nav;
            patientActivitiesButtonCommand = new RelayCommand(() => _nav.NavigateTo(PatientLoc.ptActivitiesPage));
			imagetap= new TapGestureRecognizer {
				Command = new Command (() => 
					_nav.NavigateTo(PatientLoc.ptActivitiesPage)
				),
				NumberOfTapsRequired = 1
				};
        }

        public ICommand patientActivitiesButtonCommand
        {
            get;
            set;
        }

		public TapGestureRecognizer imagetap {
			get;
			set;
		}



        // getter and setter for mood value


    }
}
