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
	public class PatientListPageViewModel:ViewModelBase
	{
		private INavigationService _nav;
		public PatientListPageViewModel (INavigationService nav)
		{
			_nav = nav;

		}
	}
}

