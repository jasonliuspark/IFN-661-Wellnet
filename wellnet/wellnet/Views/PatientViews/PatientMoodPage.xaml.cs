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
            /* Draw Status Block */
            var MessageText = new Label()
            {
                Text = "Hello Dorris. You have an appointment with Dr. Doe at 3pm.",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("2196F3"),
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            var imgBtnPatientMedication = new FileImageSource();
            imgBtnPatientMedication.File = "MedicationButton.jpg";

            /*draw menu buttons */
            var BtnPatientMedication = new Button()
            {
                Image = imgBtnPatientMedication,
                BackgroundColor = Color.FromHex("673AB7"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("4527A0"),
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button))
            };

            BtnPatientMedication.SetBinding(Button.CommandProperty, "patientMedication");

            var imgBtnPatientActivities = new FileImageSource();
            imgBtnPatientActivities.File = "btnPatientActivities.jpg";

            var BtnPatientActivities = new Button()
            {
                Image = imgBtnPatientActivities,
                BackgroundColor = Color.FromHex("2196F3"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("1565C0"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };

            BtnPatientActivities.SetBinding(Button.CommandProperty, "patientActivities");
            
            var imgBtnPatientMoods = new FileImageSource();
            imgBtnPatientMoods.File = "btnPatientMood.jpg";

            var BtnPatientMoods = new Button()
            {
                Image = imgBtnPatientMoods,
                BackgroundColor = Color.FromHex("4CAF50"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("2E7D32"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };

            BtnPatientMoods.SetBinding(Button.CommandProperty, "patientMoods");

            ///* draw button stack */
            var DorisMenuStack = new StackLayout()
            {
                Spacing = 10,
                Padding = 10,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /* fill the stack with buttons*/
            DorisMenuStack.Children.Add(MessageText);
            DorisMenuStack.Children.Add(BtnPatientMedication);
            DorisMenuStack.Children.Add(BtnPatientActivities);
            DorisMenuStack.Children.Add(BtnPatientMoods);

            /* fill the content page*/
            this.Content = DorisMenuStack;
            BindingContext = App.PatientLoc.PatientMood ;

        }
    }
}
