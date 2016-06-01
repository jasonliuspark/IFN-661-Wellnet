using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using System.Diagnostics;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight;

namespace wellnet.ViewModels.PatientViewModels
{
    public class PatientActivitiesPageViewModel : ViewModelBase
    {
		private IEnumerable<PatientDetails> ptdetails;
		private string[] patientActivites;

        public PatientActivitiesPageViewModel()
        {
			var db = new DBInit ();

			ptdetails = db.GetDetails ();

			patientActivites = spliter (db.GetDetails());

			foreach (var pa in patientActivites){
				Debug.WriteLine ("Debug string split: " + pa );
			}
				

        }

		public string[] spliter (IEnumerable<PatientDetails> ptdetails)
		{
		
			string activity = ptdetails.First ().PatientActivities.ToString();
			char[] delimiters = { ','};

			string[]tt = activity.Split(delimiters);
			return tt;
		}

		public string[] PatientActivities {
			get{ 
				return this.patientActivites;
			
			}
			set
			{

				this.patientActivites = value;

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


    }
}
