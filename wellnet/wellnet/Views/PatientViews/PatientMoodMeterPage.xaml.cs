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
            /*
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
            /*MoodMeter.Children.Add(imgMoodMeter);*/
            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            List<string> moodList = new List<string>();
            moodList.Add("Happy.png");
            moodList.Add("Excited.png");
            moodList.Add("Sad.png");
            moodList.Add("Sick.png");

            var happyMoodImage = new Image { Aspect = Aspect.AspectFit };
            happyMoodImage.Source = ImageSource.FromFile("Happy.png");

            var sadMoodImage = new Image { Aspect = Aspect.AspectFit };
            sadMoodImage.Source = ImageSource.FromFile("Sad.png");

            var excitedMoodImage = new Image { Aspect = Aspect.AspectFit };
            excitedMoodImage.Source = ImageSource.FromFile("Excited.png");

            var sickMoodImage = new Image { Aspect = Aspect.AspectFit };
            sickMoodImage.Source = ImageSource.FromFile("Sick.png");


            /* allocate icons to various parts of the grid */
            grid.Children.Add(happyMoodImage, 0, 0);
            grid.Children.Add(new Label { Text = "Happy?" }, 1, 0);
            grid.Children.Add(sadMoodImage, 0, 1);
            grid.Children.Add(new Label { Text = "Sad?" }, 1, 1);
            grid.Children.Add(excitedMoodImage, 0, 2);
            grid.Children.Add(new Label { Text = "Excited?" }, 1, 2);
            grid.Children.Add(sickMoodImage, 0, 3);
            grid.Children.Add(new Label { Text = "Sick?" }, 1, 3);


            /* check box */
            Switch checkboxHappy = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            //checkboxHappy.Toggled += checkBoxToggled;


            this.Content = grid;
        }
    }
}
