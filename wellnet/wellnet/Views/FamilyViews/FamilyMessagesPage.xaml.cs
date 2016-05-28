using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace wellnet.Views.FamilyViews
{
    public partial class FamilyMessagesPage : ContentPage
    {
        public FamilyMessagesPage()
        {
            InitializeComponent();
            /* Agenda */
            var MessagesStatus = new Label()
            {
                Text = "Messages",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            var MessagesStatusPic = new Image { Aspect = Aspect.Fill };
            {
                MessagesStatusPic.Source = ImageSource.FromFile("Messages.jpg");
            };

            var BackgroundGrid = new Image();

            /*-----stacklayouts---*/
            var Messages_Status = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /*monitoring grids layout */
            var AgendaGrid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions ={
                    new RowDefinition{Height=GridLength.Auto},
                    new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    },
                ColumnDefinitions ={
                    new ColumnDefinition{ Width=GridLength.Auto},
                }
            };

            AgendaGrid.Children.Add(MessagesStatusPic);

            this.Content = AgendaGrid;
        }

    }
}
