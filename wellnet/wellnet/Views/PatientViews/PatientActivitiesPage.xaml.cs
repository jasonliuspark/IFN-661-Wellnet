using System;
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

            //InitializeComponent();


            /* Activities */
            var ActivitiesStatus = new Label()
            {
                Text = "Activities",
                TextColor = Color.FromHex("#4CAF50"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var ActivitiesStatusPic = new Image { Aspect = Aspect.AspectFit };
            {
                ActivitiesStatusPic.Source = ImageSource.FromFile("HeartRate.jpg");
            };

            var BackgroundGrid = new Image();

            /*-----stacklayouts---*/
            var Activities_Status = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.Fill,
            };

            /*monitoring grids layout */
            var ActivitiesGrid = new Grid
            {
                VerticalOptions = LayoutOptions.Start,   //.FillAndExpand,
                RowDefinitions ={
                    new RowDefinition{Height=530},
                    },
                ColumnDefinitions ={
                    new ColumnDefinition{ Width=360},
                }
            };

            /*fill stack */
//            ActivitiesGrid.Children.Add(ActivitiesStatusPic);

            this.Content = ActivitiesGrid;
        }
    }

}
