﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using SQLitePCL;
namespace wellnet.UI
{
    public partial class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            /* Draw Status Block */
            var MessageText = new Label()
            {
                Text = "Hello Wayne. Dorris is feeling HAPPY today. She has an appointment with the doctor at 2pm.",
                TextColor = Color.Red,
                BackgroundColor = Color.FromHex("b39ddb"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            /*draw menu buttons */
            var BtnDorisMedication = new Button()
            {
                Text = "Doris Medication",
                TextColor = Color.Red,
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            var BtnDorisVitals = new Button()
            {
                Text = "Doris Vitals",
                TextColor = Color.Blue,
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            var BtnDorisAgenda = new Button()
            {
                Text = "Doris Agenda",
                TextColor = Color.Green,
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            /* draw button stack */
            var DorisMenuStack = new StackLayout()
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /* fill the stack with buttons*/

            DorisMenuStack.Children.Add(MessageText);
            DorisMenuStack.Children.Add(BtnDorisMedication);
            DorisMenuStack.Children.Add(BtnDorisVitals);
            DorisMenuStack.Children.Add(BtnDorisAgenda);

            /* set click listener */
            //MenuButtonController menu = new MenuButtonController ();
            BtnDorisMedication.Clicked += onDorisMedicationButtonClicked;
            BtnDorisVitals.Clicked += onDorisVitalsButtonClicked;
            BtnDorisAgenda.Clicked += onDorisAgendaButtonClicked;

            /* fill the content page*/
            this.Content = DorisMenuStack;

        }

        /*button listeners  */
        public async void onDorisMedicationButtonClicked(object sender, EventArgs e)
        {
            //todo: Family view
            await Navigation.PushAsync(new FamilyMedication());
        }

        public async void onDorisVitalsButtonClicked(object sender, EventArgs e)
        {
            //todo: Family view
            await Navigation.PushAsync(new FamilyVitals());
        }
        public void onDorisAgendaButtonClicked(object sender, EventArgs e)
        {
            //todo: Patient view
        }
    }
}
