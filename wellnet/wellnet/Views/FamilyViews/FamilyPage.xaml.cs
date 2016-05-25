using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using wellnet;

namespace wellnet
{
    public partial class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            InitializeComponent();
            BindingContext = App.FamilyLoc.FamilyPage;
            
        }
    }
}
