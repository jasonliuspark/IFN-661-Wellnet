using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace wellnet
{
    public partial class PatientMoodPage : ContentPage
    {
        public PatientMoodPage()
        {
            InitializeComponent();
			BindingContext = App.PatientLoc.PatientMood;
			imagebutton.GestureRecognizers.Add (App.PatientLoc.PatientMood.imagetap);
		
		}
    }
}
