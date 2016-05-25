using System;
using Xamarin.Forms;
using GalaSoft.MvvmLight;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace wellnet
{
	public class PatientListPageViewModel:ViewModelBase
	{
		//private INavigationService _nav;
		private IEnumerable<PatientDetails> ptdetails;

		public PatientListPageViewModel ()
		{
			var db = new DBInit ();
			ptdetails= db.GetDetails ();

			foreach(var s in ptdetails)
			{
				
				Debug.WriteLine (s + "is printed out");

			}

		}
		public IEnumerable<PatientDetails> PtDetails {

			get{ 
			
				return this.ptdetails;
			}

			set{  
				this.ptdetails = value;

			}

		}

		public ICommand listTapCommand {
			get;
			set;
		}


	}
}

