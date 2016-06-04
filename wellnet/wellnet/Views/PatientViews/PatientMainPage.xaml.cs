﻿using System;
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
			NavigationPage.SetTitleIcon (this,"wellnet_logo_mini.png");
            /* Draw Status Block */
            var MessageText = new Label()
            {
                Text = "Hello Dorris!",
                TextColor = Color.Accent,
                BackgroundColor = Color.FromHex("2196F3"),
                HorizontalOptions = LayoutOptions.Center,
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
            
            var imgBtnPatientMoodMeter = new FileImageSource();
            imgBtnPatientMoodMeter.File = "btnPatientMood.jpg";

            var BtnPatientMoodMeter = new Button()
            {
                Image = imgBtnPatientMoodMeter,
                BackgroundColor = Color.FromHex("4CAF50"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("2E7D32"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };

            BtnPatientMoodMeter.SetBinding(Button.CommandProperty, "patientMoodMeter");

            /* Button for calling staff */
            var imgBtnPatientCallStaff = new FileImageSource();
            imgBtnPatientCallStaff.File = "btnCallStaff.png";
            var BtnPatientCallStaff = new Button()
            {
                Image = imgBtnPatientCallStaff,
                BackgroundColor = Color.FromHex("4CAF50"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("2E7D32"),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };


            ///* draw button stack */
            var DorisMenuStack = new StackLayout()
            {
                Spacing = 10,
                Padding = new Thickness (10, 10, 10, 10),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            /* fill the stack with buttons*/
            
            DorisMenuStack.Children.Add(MessageText);
            DorisMenuStack.Children.Add(BtnPatientMedication);
            DorisMenuStack.Children.Add(BtnPatientActivities);
            DorisMenuStack.Children.Add(BtnPatientMoodMeter);
            DorisMenuStack.Children.Add(BtnPatientCallStaff);
            /* fill the content page*/
            this.Content = DorisMenuStack;
            BindingContext = App.PatientLoc.PatientMood ;

        }
    }
}
