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
            
//            var MessageText = new Label()
//            {
//                Text = "Hello Wayne. Dorris is feeling HAPPY today. She has an appointment with Dr. Doe at 3pm.",
//                TextColor = Color.White,
//                BackgroundColor = Color.FromHex("2196F3"),
//
//                // BorderColor = Color.FromHex("4527A0"),
//                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
//            };
//
//            var imgMoodMeter = new Image { Aspect = Aspect.AspectFit };
//            {
//                imgMoodMeter.Source = ImageSource.FromFile("PatientMoods.png");
//            };
			BindingContext=App.PatientLoc.PatientMeter;
            var MoodMeter = new StackLayout()
            {
                Spacing = 10,
                Padding = 10,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
			Label happy, sad, excited, sick;

            /* Label for display purpose of page */
            Label patientQuestion = new Label()
            {
                Text = "How are you feeling today?",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                TextColor=Color.Accent
            };

			var displayMood = new Label (){

				FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
				HorizontalOptions=LayoutOptions.Center,
                TextColor=Color.Accent
			};

			displayMood.SetBinding (Label.TextProperty,"MoodDisplay");
            /* fill the stack with buttons*/
            /*MoodMeter.Children.Add(imgMoodMeter);*/
			Grid grid = new Grid{ ColumnSpacing=1,RowSpacing=1};
			grid.RowDefinitions.Add(new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}  );
			grid.RowDefinitions.Add(new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}  );
			grid.RowDefinitions.Add(new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}  );
			grid.RowDefinitions.Add(new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}  );

			grid.ColumnDefinitions.Add (new ColumnDefinition{ Width = new GridLength (1, GridUnitType.Star)  });
			grid.ColumnDefinitions.Add (new ColumnDefinition{ Width = new GridLength (1, GridUnitType.Star)  });
			grid.ColumnDefinitions.Add (new ColumnDefinition{ Width = new GridLength (1, GridUnitType.Star)  });


			var happyMoodImage = new Image (); //{ Aspect = Aspect.AspectFit };
			happyMoodImage.Source="Happy.png";

			var sadMoodImage = new Image(); //{ Aspect = Aspect.AspectFit };
            sadMoodImage.Source = ImageSource.FromFile("Sad.png");

			var excitedMoodImage = new Image(); //{ Aspect = Aspect.AspectFit };
            excitedMoodImage.Source = ImageSource.FromFile("Excited.png");

			var sickMoodImage = new Image(); //{ Aspect = Aspect.AspectFit };
            sickMoodImage.Source = ImageSource.FromFile("Sick.png");

			Switch checkboxHappy = new Switch
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			//non mvvm implementation
				//checkboxHappy.SetBinding (Switch.BehaviorsProperty,"happytoggled");
				

			Switch checkboxSad = new Switch
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			Switch checkboxExcited = new Switch
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			Switch checkboxSick = new Switch
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			//non mvvm toggled event 
			checkboxHappy.Toggled += delegate(object sender, ToggledEventArgs e) {
				if (checkboxHappy.IsToggled==true)
				{displayMood.Text = "Your mood today is happy.";}
				else {
					displayMood.Text="";
				}		 
			};

			checkboxSad.Toggled += delegate(object sender, ToggledEventArgs e) {
				if (checkboxSad.IsToggled==true)
				{displayMood.Text = "Your mood today is sad.";}
				else {
					displayMood.Text="";
				}		 
			};
			checkboxExcited.Toggled += delegate(object sender, ToggledEventArgs e) {
				if (checkboxExcited.IsToggled==true)
				{displayMood.Text = "You are excited today!";}
				else {
					displayMood.Text="";
				}		 
			};
			checkboxSick.Toggled += delegate(object sender, ToggledEventArgs e) {
				if (checkboxSick.IsToggled==true)
				{displayMood.Text = "You are not feeling very well today.";}
				else {
					displayMood.Text="";
				}		 
			};

            /* allocate icons to various parts of the grid */
            grid.Children.Add(happyMoodImage, 0, 0);
			grid.Children.Add(happy= new Label
            {
                Text = "Happy?",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor=Color.Accent
            }, 1, 0);
            grid.Children.Add(sadMoodImage, 0, 1);
			grid.Children.Add(sad= new Label
            {
                Text = "Sad?",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Accent
            }, 1, 1);
            grid.Children.Add(excitedMoodImage, 0, 2);
            grid.Children.Add(excited=new Label
            {
                Text = "Excited?",
                HorizontalOptions =LayoutOptions.Center,
                VerticalOptions =LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Accent
            }, 1, 2);
            grid.Children.Add(sickMoodImage, 0, 3);
			grid.Children.Add(sick= new Label
            {
                Text = "Sick?",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Accent
            }, 1, 3);
			grid.Children.Add (checkboxHappy, 2, 0);
			grid.Children.Add (checkboxSad, 2, 1);
			grid.Children.Add (checkboxExcited, 2, 2);
			grid.Children.Add (checkboxSick, 2, 3);
            /* check box */

            MoodMeter.Children.Add(patientQuestion);
			MoodMeter.Children.Add (grid);
			MoodMeter.Children.Add (displayMood);
			this.Content = MoodMeter;
        }
    }
}
