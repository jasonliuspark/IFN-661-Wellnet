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
                Text = " Hello Wayne. Dorris is feeling HAPPY    today. She has an appointment with Dr.    Doe at 3pm.",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("2196F3"),
               // BorderColor = Color.FromHex("4527A0"),
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))              

            };

            /*draw menu buttons */
            var BtnDorisMedication = new Button()
            {
                Text = "Doris Medication",
                TextColor = Color.FromHex("EDE7F6"),
                BackgroundColor = Color.FromHex("673AB7"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("4527A0"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            
            BtnDorisMedication.SetBinding(Button.CommandProperty, "familymedication");

            var BtnDorisVitals = new Button()
            {
                Text = "Doris Vitals",
                TextColor = Color.FromHex("FFEBEE"),
                BackgroundColor = Color.FromHex("F44336"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("C62828"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };

            BtnDorisVitals.SetBinding(Button.CommandProperty, "familyvitals");


            var BtnDorisAgenda = new Button()
            {
                Text = "Doris Agenda",
                TextColor = Color.FromHex("F5E9E8"),
                BackgroundColor = Color.FromHex("4CAF50"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("2E7D32"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };

            BtnDorisAgenda.SetBinding(Button.CommandProperty, "familyagenda");

            var BtnDorisMessages = new Button()
            {
                Text = "Family Messages",
                TextColor = Color.FromHex("E3F2FD"),
                BackgroundColor = Color.FromHex("2196F3"),
                BorderRadius = 2,
                BorderWidth = 2,
                BorderColor = Color.FromHex("1565C0"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
                
            };


            BtnDorisMessages.SetBinding(Button.CommandProperty, "familymessages");
            /* draw button stack */
            var DorisMenuStack = new StackLayout()
            {
                Spacing = 10,
                Padding = 10,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /* fill the stack with buttons*/

            DorisMenuStack.Children.Add(MessageText);
            
            DorisMenuStack.Children.Add(BtnDorisMedication);
            DorisMenuStack.Children.Add(BtnDorisVitals);
            DorisMenuStack.Children.Add(BtnDorisAgenda);
            DorisMenuStack.Children.Add(BtnDorisMessages);           

            /* fill the content page*/
            this.Content = DorisMenuStack;
            BindingContext = App.FamilyLoc.FamilyPage;
        }
    }
}
