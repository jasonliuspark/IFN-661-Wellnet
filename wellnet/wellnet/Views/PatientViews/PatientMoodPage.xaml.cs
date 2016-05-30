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

            var imgBtnDorisMedication = new FileImageSource();
            imgBtnDorisMedication.File = "MedicationButton.jpg";

            /*draw menu buttons */
            var BtnDorisMedication = new Button()
            {
                Image = imgBtnDorisMedication,
                BackgroundColor = Color.FromHex("673AB7"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("4527A0"),
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button))
            };

            BtnDorisMedication.SetBinding(Button.CommandProperty, "familymedication");

            var imgBtnDorisActivities = new FileImageSource();
            imgBtnDorisActivities.File = "DorisActivities.jpg";

            var BtnDorisActivities = new Button()
            {
                // Text = "Doris Agenda",
                //TextColor = Color.FromHex("F5E9E8"),
                Image = imgBtnDorisActivities,
                BackgroundColor = Color.FromHex("2196F3"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("1565C0"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };

            //BtnDorisAgenda.SetBinding(Button.CommandProperty, "familyagenda");


            var imgBtnDorisMood = new FileImageSource();
            imgBtnDorisMood.File = "DorisMood.jpg";

            var BtnDorisMood = new Button()
            {
                //Text = "Doris Vitals",
                //TextColor = Color.FromHex("FFEBEE"),
                Image = imgBtnDorisMood,
                BackgroundColor = Color.FromHex("4CAF50"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("2E7D32"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };

            //BtnDorisVitals.SetBinding(Button.CommandProperty, "familyvitals");

            ///* draw button stack */
            var DorisMenuStack = new StackLayout()
            {
                Spacing = 10,
                Padding = 10,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /* fill the stack with buttons*/
            DorisMenuStack.Children.Add(MessageText);
            DorisMenuStack.Children.Add(BtnDorisMedication);
            DorisMenuStack.Children.Add(BtnDorisActivities);
            DorisMenuStack.Children.Add(BtnDorisMood);
            //DorisMenuStack.Children.Add(BtnDorisMessages);

            /* fill the content page*/
            this.Content = DorisMenuStack;
            BindingContext = App.FamilyLoc.FamilyPage;

        }
    }
}
