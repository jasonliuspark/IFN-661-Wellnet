using System;
using Xamarin.Forms;
using GalaSoft.MvvmLight;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;


namespace wellnet

{
	public class PatientMoodPageViewModel:ViewModelBase

    {	
		private IEnumerable<PatientDetails> ptdetails;

        public PatientMoodPageViewModel()
        {
			var db = new DBInit ();
			ptdetails= db.GetDetails ();



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
