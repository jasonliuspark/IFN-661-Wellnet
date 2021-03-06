﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.Views.PatientViews
{
    public partial class PatientActivities : ContentPage
    {
        public PatientActivities()
        {
			NavigationPage.SetTitleIcon (this,"wellnet_logo_mini.png");
            /* Draw Status Block 
            var MessageText = new Label()
            {
                Text = "Hello Dorris. You have an appointment with Dr. Doe at 3pm.",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("2196F3"),
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            var ActivitiesStatusPic = new Image { Aspect = Aspect.AspectFit };
            {
                ActivitiesStatusPic.Source = ImageSource.FromFile("PatientActivities.png");
            };

            ///* draw button stack 
            var DorisMenuStack = new StackLayout()
            {
                Spacing = 10,
                Padding = 10,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /* fill the stack with buttons
           // DorisMenuStack.Children.Add(MessageText);
            DorisMenuStack.Children.Add(ActivitiesStatusPic);
            //DorisMenuStack.Children.Add(MessageText);
            
            /* fill the content page
            this.Content = DorisMenuStack;*/
            /*
            ListView patientActivities = new ListView();
            patientActivities.ItemsSource = new string[] {
                "9:00AM Physio appointment",
                "12:00AM Lunch with Beth",
                "5:00PM Take Medication"
            };*/
            /* uncomment this to compile xaml */
            //InitializeComponent();
            /* stack layout */
            DayOfWeek currentTime = DateTime.Now.DayOfWeek;
            var ActivitiesPage = new StackLayout()
            {
                // Remove Extra spacing from the top of the page
                Padding = 10,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            Label activitiesTitle = new Label()
            {
                Text = String.Format("Activities Today ({0}):", currentTime),
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Accent,
                HorizontalOptions = LayoutOptions.Center,
            };

            BindingContext = App.PatientLoc.PatientActivities;

			ListView ptactivity = new ListView ();
            
			ptactivity.SetBinding (ListView.ItemsSourceProperty,"PatientActivities");
            StackLayout patientActivities = new StackLayout()
            {
                Padding = new Thickness(10, 10, 10, 10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            patientActivities.Children.Add(ptactivity);
            ActivitiesPage.Children.Add(activitiesTitle);
            ActivitiesPage.Children.Add(patientActivities);
			this.Content = ActivitiesPage;
        }
    }

}
