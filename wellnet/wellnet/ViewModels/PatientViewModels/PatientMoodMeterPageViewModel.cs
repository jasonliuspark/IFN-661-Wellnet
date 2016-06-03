using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Diagnostics;
using System.Windows.Input;


namespace wellnet.ViewModels.PatientViewModels
{
    public class PatientMoodMeterPageViewModel : ViewModelBase
    {
		public	string moodDisplay;
        public PatientMoodMeterPageViewModel()
        {
			happytoggled = new RelayCommand (()=> {moodDisplay="happy";
				Debug.WriteLine("debuggggg");
			});
			happyuntoggled = new RelayCommand (()=>moodDisplay = " ");
			sadtoggled = new RelayCommand ( ()=>moodDisplay="sad");
			saduntoggled = new RelayCommand (()=>moodDisplay = " ");
			excitedtoggled = new RelayCommand ( ()=>moodDisplay="excited");
			exciteduntoggled = new RelayCommand (()=>moodDisplay = " ");
			sicktoggled = new RelayCommand ( ()=>moodDisplay="sick");
			sickuntoggled = new RelayCommand (()=>moodDisplay = " ");


        }



		public String MoodDisplay {
			get{ 
				return this.moodDisplay;
			}
			set{
				this.moodDisplay = value;
				base.RaisePropertyChanged ("MoodDisplay");
			}
		}

		public ICommand happytoggled {
			get;
			set;
		}

		public ICommand happyuntoggled {

			get;
			set;
		}

		public ICommand sadtoggled {
			get;
			set;
		}

		public ICommand saduntoggled {

			get;
			set;
		}
		public ICommand excitedtoggled {
			get;
			set;
		}

		public ICommand exciteduntoggled {

			get;
			set;
		}
		public ICommand sicktoggled {
			get;
			set;
		}

		public ICommand sickuntoggled {

			get;
			set;
		}
	    

    }
}
