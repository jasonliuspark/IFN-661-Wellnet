using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.Views.FamilyViews
{
    public partial class FamilyVitalsPage : ContentPage
    {
        public FamilyVitalsPage()
        {
			NavigationPage.SetTitleIcon (this,"wellnet_logo_mini.png");
            InitializeComponent();
            /* blood presure items */
            var BloodPressureStatus = new Label()
            {
                Text = "Heart Rate",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var BloodPressureStatusPic = new Image { Aspect = Aspect.AspectFill};
            {
                BloodPressureStatusPic.Source = ImageSource.FromFile("HeartRate.jpg");
            };

            /* body temperature items*/
            var BodyTempStatus = new Label()
            {
                Text = "Temperature",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var BodyTempStatusPic = new Image { Aspect = Aspect.AspectFill };
            {
                BodyTempStatusPic.Source = ImageSource.FromFile("BodyTemp.jpg");
            };

            /*--------------*/

            var ExcerciseMonitor = new Label()
            {
                Text = "Pedometer",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var ExcerciseMonitorPic = new Image { Aspect = Aspect.AspectFill};
            {
                ExcerciseMonitorPic.Source = ImageSource.FromFile("StepMonitor.jpg");
            };


            var BackgroundGrid = new Image();

            /*-----stacklayouts---*/
            /*  stack for blood presure  */
            var StackBloodPressure = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            /* stack for body temperature */
            var StackBodyTemp = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            /* stack for oxygen stack*/
            var ExcertionMonitor = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /*monitoring grids layout */
            var MonitoringGrids = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions ={
                    new RowDefinition{Height= new GridLength(2)},
                    new RowDefinition{Height= new GridLength(30)},
                    new RowDefinition{Height= new GridLength(130)},
                    new RowDefinition{Height= new GridLength(30)},
                    new RowDefinition{Height= new GridLength(130)},
                    new RowDefinition{Height= new GridLength(30)},
                    new RowDefinition{Height= new GridLength(190)},
                    },
                ColumnDefinitions ={
                    new ColumnDefinition{ Width=GridLength.Auto},
                    new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star)},
                }
            };

            /*fill blood presure stack */
            StackBloodPressure.Children.Add(BloodPressureStatus);

            /*fill body temp stack*/
            StackBodyTemp.Children.Add(BodyTempStatus);

            /*fill Excertion stack*/
            ExcertionMonitor.Children.Add(ExcerciseMonitor);

            /*fill monitoring grids*/
            MonitoringGrids.Children.Add(StackBloodPressure, 1, 1);
            MonitoringGrids.Children.Add(BloodPressureStatusPic, 1, 2);

            MonitoringGrids.Children.Add(BodyTempStatus, 1, 3);
            MonitoringGrids.Children.Add(BodyTempStatusPic, 1, 4);

            MonitoringGrids.Children.Add(ExcerciseMonitor, 1, 5);
            MonitoringGrids.Children.Add(ExcerciseMonitorPic, 1, 6);

            /*grid style*/
            //this.Padding = new Thickness(30, 30, 10, 10);
            this.Content = MonitoringGrids;
        }
    }
}
