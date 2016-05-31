using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.Views.PatientViews
{
    public partial class PatientMedicationPage : ContentPage
    {
        public PatientMedicationPage()
        {
            InitializeComponent();
            BindingContext = App.PatientLoc.PatientMedication;
        }
    }
}
