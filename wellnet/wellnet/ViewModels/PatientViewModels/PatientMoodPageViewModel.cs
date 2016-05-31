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

        private INavigationService _nav;
        public PatientMoodPageViewModel(INavigationService nav )
        {
            var db = new DBInit();
            _nav = nav;

            patientMedication = new RelayCommand(() => _nav.NavigateTo(PatientLoc.patientMedicationPage));
            patientActivities = new RelayCommand(() => _nav.NavigateTo(PatientLoc.patientActivitiesPage));
            patientMoods = new RelayCommand(() => _nav.NavigateTo(PatientLoc.patientMoodsPage));

    //        imagetap = new TapGestureRecognizer {
				//Command = new Command (() => 
				//	_nav.NavigateTo(PatientLoc.patientActivitiesPage)
				//),
				//NumberOfTapsRequired = 1
				//};
        }

        public ICommand patientActivities
        {
            get;
            set;
        }

		public TapGestureRecognizer imagetap {
			get;
			set;
		}



        public ICommand patientMedication
        {
            get;
            set;
        }

        public ICommand patientMoods
        {
            get;
            set;
        }
        
        // getter and setter for mood value


    }
}
