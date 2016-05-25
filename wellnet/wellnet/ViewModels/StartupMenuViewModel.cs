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
            patientButtonCommand = new RelayCommand(() => _nav.NavigateTo(PatientLoc.ptMoodPage));
        }

		public ICommand doc_buttonCommand {
			get;
			set;
		}

		public ICommand patientButtonCommand {
			get;
			set;
		}
	
	}
}

