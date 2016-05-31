using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.Views.PatientViews
{
    public partial class PatientMoodMeterPage : ContentPage
    {
        public PatientMoodMeterPage()
        {
			NavigationPage.SetTitleIcon (this,"wellnet_logo_mini.png");
            /* Draw Status Block */
            var MessageText = new Label()
            {
                Text = "Hello Wayne. Dorris is feeling HAPPY today. She has an appointment with Dr. Doe at 3pm.",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("2196F3"),

                // BorderColor = Color.FromHex("4527A0"),
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            var imgMoodMeter = new Image { Aspect = Aspect.AspectFit };
            {
                imgMoodMeter.Source = ImageSource.FromFile("PatientMoods.png");
            };

            var MoodMeter = new StackLayout()
            {
                Spacing = 10,
                Padding = 10,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /* fill the stack with buttons*/
            MoodMeter.Children.Add(imgMoodMeter);

            this.Content = MoodMeter;
        }
    }
}
