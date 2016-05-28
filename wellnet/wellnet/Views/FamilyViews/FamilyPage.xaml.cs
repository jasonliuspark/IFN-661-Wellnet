using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.Views.FamilyViews
{
    public partial class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            /* Draw Status Block */
            var MessageText = new Label()
            {
                Text = "Hello Wayne. Dorris is feeling HAPPY today. She has an appointment with Dr. Doe at 3pm.",
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
            //var BtnDorisMedication = new Image { Aspect = Aspect.AspectFit };
            //{
            //    BtnDorisMedication.Source = ImageSource.FromFile("MedicationButton.jpg");
            //};

            BtnDorisMedication.SetBinding(Button.CommandProperty, "familymedication");

            var BtnDorisVitals = new Button()
            {
                Text = "Doris Vitals",
                TextColor = Color.Blue,
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            BtnDorisVitals.SetBinding(Button.CommandProperty, "familyvitals");


            var BtnDorisAgenda = new Button()
            {
                Text = "Doris Agenda",
                TextColor = Color.Green,
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            BtnDorisAgenda.SetBinding(Button.CommandProperty, "familyagenda");

            var BtnDorisMessages = new Button()
            {
                Text = "Family Messages",
                TextColor = Color.Purple,
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
            DorisMenuStack.Children.Add(BtnDorisMessages);

            /* set click listener */
            //MenuButtonController menu = new MenuButtonController ();
            //BtnDorisMedication.Clicked += onDorisMedicationButtonClicked;
            //BtnDorisVitals.Clicked += onDorisVitalsButtonClicked;
            //BtnDorisAgenda.Clicked += onDorisAgendaButtonClicked;
            //BtnDorisMessages.Clicked += onDorisMessageButtonClicked;

            /* fill the content page*/
            this.Content = DorisMenuStack;
            BindingContext = App.FamilyLoc.FamilyPage;
        }

        /*button listeners  */
        //public async void onDorisMedicationButtonClicked(object sender, EventArgs e)
        //{
        //    // Family Medication
        //    await Navigation.PushAsync(new FamilyMedication());
        //}

        //public async void onDorisVitalsButtonClicked(object sender, EventArgs e)
        //{
        //    // Family Vitals
        //    await Navigation.PushAsync(new FamilyVitals());
        //}
        //public void onDorisAgendaButtonClicked(object sender, EventArgs e)
        //{
        //    // Famil
        //}

        //public async void onDorisMessageButtonClicked(object sender, EventArgs e)
        //{
        //    // Family Messages
        //    await Navigation.PushAsync(new FamilyMessages());

        ////}
    }
}
