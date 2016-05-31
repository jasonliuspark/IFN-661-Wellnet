using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.Views.FamilyViews
{
    public partial class FamilyMedication : ContentPage
    {
        public FamilyMedication()
        {
            InitializeComponent();
			NavigationPage.SetTitleIcon (this,"wellnet_logo_mini.png");
            BindingContext = App.FamilyLoc.FamilyMedication1;

        }
    }
}
