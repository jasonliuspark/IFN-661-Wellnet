using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.Views.FamilyViews
{
    public partial class FamilyMessages : ContentPage
    {
        public FamilyMessages()
        {
            /* Messages */
            var MessageStatus = new Label()
            {
                Text = "Messages :)",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var MessagesPic = new Image { Aspect = Aspect.AspectFit };
            {
                MessagesPic.Source = ImageSource.FromFile("HeartRate.jpg");
            };

            var BackgroundGrid = new Image();

            /*-----stacklayouts---*/
            var Message_Status = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /*monitoring grids layout */
            var MessageGrid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions ={
                    new RowDefinition{Height=GridLength.Auto},
                    //new RowDefinition{Height=GridLength.Auto},
                    },
                ColumnDefinitions ={
                    new ColumnDefinition{ Width=GridLength.Auto},
                    //new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star)},
                }
            };

            /*fill Messages stack */
            // MessageGrid.Children.Add(MessageStatus);
            MessageGrid.Children.Add(MessageStatus, 0, 0);

            /*grid style*/
            this.Padding = new Thickness(30, 30, 10, 10);
            this.Content = MessageGrid;

        }
    }
}
