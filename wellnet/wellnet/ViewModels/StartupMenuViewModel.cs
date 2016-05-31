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
	public class StartupMenuViewModel:ViewModelBase
	{
		private INavigationService _nav;

		public StartupMenuViewModel (INavigationService nav)
		{
			_nav = nav;
			doc_buttonCommand = new RelayCommand (()=>_nav.NavigateTo(MediLoc.ptlistPage));
            patientButtonCommand = new RelayCommand(() => _nav.NavigateTo(PatientLoc.patientMoodPage));
            familyButtonCommand = new RelayCommand(() => _nav.NavigateTo(FamilyLoc.familyPage));


            //docTap = new TapGestureRecognizer
            //{
            //    Command = new Command(() =>
            //      _nav.NavigateTo(MediLoc.ptlistPage)
            //     ),
            //    NumberOfTapsRequired = 1
            //     };
            //familyTap = new TapGestureRecognizer
            //{
            //    Command = new Command(() =>
            //      _nav.NavigateTo(FamilyLoc.familyPage)
            //     ),
            //    NumberOfTapsRequired = 1
            //};
            //patientTap = new TapGestureRecognizer
            //{
            //    Command = new Command(() =>
            //      _nav.NavigateTo(PatientLoc.ptMoodPage)
            //     ),
            //    NumberOfTapsRequired = 1
            //};


        }
        // public TapGestureRecognizer docTap
        //  {
        //      get;
        //      set;
        //  }

        //public TapGestureRecognizer patientTap
        //{
        //    get;
        //    set;
        //}

        //public TapGestureRecognizer familyTap
        //{
        //    get;
        //    set;
        //}

        public ICommand doc_buttonCommand {
			get;
			set;
		}

        public ICommand patientButtonCommand
        {
            get;
            set;
        }

        public ICommand familyButtonCommand
        {
            get;
            set;
        }


	
	}
}

