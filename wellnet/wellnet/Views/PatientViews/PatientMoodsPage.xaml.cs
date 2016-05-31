using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.Views.PatientViews
{
    public partial class PatientMoodsPage : ContentPage
    {
        public void PatientMoods()
        {
            InitializeComponent();
            /* Moods */
            var MoodsStatus = new Label()
            {
                Text = "Moods",
                TextColor = Color.FromHex("#4CAF50"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var MoodsStatusPic = new Image { Aspect = Aspect.AspectFit };
            {
                MoodsStatusPic.Source = ImageSource.FromFile("SmallMoods.jpg");
            };

            var BackgroundGrid = new Image();

            /*-----stacklayouts---*/
            /*  stack for calendar  */
            var Moods_Status = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.Fill,
            };

            /*monitoring grids layout */
            var MoodsGrid = new Grid
            {
                VerticalOptions = LayoutOptions.Start,   //.FillAndExpand,
                RowDefinitions ={
                    new RowDefinition{Height=530},
                    //new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    },
                ColumnDefinitions ={
                    new ColumnDefinition{ Width=360},
                    //new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star)},
                }
            };

            /*fill blood presure stack */
            MoodsGrid.Children.Add(MoodsStatusPic);

            /*grid style*/
            //this.Padding = new Thickness(30, 30, 10, 10);
            this.Content = MoodsGrid;
        }

    }
}
