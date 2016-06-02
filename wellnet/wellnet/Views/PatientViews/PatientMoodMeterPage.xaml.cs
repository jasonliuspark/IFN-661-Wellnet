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

        string buttonClickedText;
        int clickTotal = 0;
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

            /* assign mood images to array and assign file discreptors into variables */
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

            /* Add label asking question */
            Label patientQuestion = new Label
            {
                Text = "Button",
                Font = Font.BoldSystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            Label patientConfirm = new Label
            {
                Text = "You have selected: x",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };


            /* Add buttons */
            Button happyButton = new Button
            {
                Text = "Happy?",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            happyButton.Clicked += OnButtonClicked;

            Button sadButton = new Button
            {
                Text = "Sad?",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            sadButton.Clicked += OnButtonClicked;

            Button excitedButton = new Button
            {
                Text = "Excited?",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            sadButton.Clicked += OnButtonClicked;

            Button sickButton = new Button
            {
                Text = "Happy?",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            sickButton.Clicked += OnButtonClicked;


            /* allocate icons to various parts of the grid */
            grid.Children.Add(patientQuestion, 0, 0);
            Grid.SetColumnSpan(patientQuestion, 3);

            grid.Children.Add(happyMoodImage, 0, 1);
            grid.Children.Add(happyButton, 1, 1);

            grid.Children.Add(sadMoodImage, 0, 2);
            grid.Children.Add(sadButton, 1, 2);

            grid.Children.Add(excitedMoodImage, 0, 3);
            grid.Children.Add(excitedButton, 1, 3);

            grid.Children.Add(sickMoodImage, 0, 4);
            grid.Children.Add(sickButton, 1, 4);

            grid.Children.Add(patientConfirm, 0, 5);
            Grid.SetColumnSpan(patientConfirm, 3);

            /* check box */
            Switch checkboxHappy = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            //checkboxHappy.Toggled += checkBoxToggled;


            this.Content = grid;
        }
        // TODO: Do I need to make a separat method for each of the different types of buttons to click? Will do tomorrow with Jason
        void OnButtonClicked(object sender, EventArgs e)
        {
            buttonClickedText += "you have selected a mood";
            //patientConfirm.Text = String.Format("{0} button click{1}",
                                       clickTotal, clickTotal == 1 ? "" : "s");
        }
    }
}
