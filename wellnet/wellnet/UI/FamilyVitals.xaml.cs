using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SQLite;

using Xamarin.Forms;

namespace wellnet.UI
{
    //public interface ISQLite
    //{
    //    SQLiteConnection GetConnection();
    //}

    //public WellnetDatabase()
    //{
    //    database = DependencyService.Get<ISQLite>().GetConnection();
    //    database.CreateTable<medication>();
    //}

    //public IEnumerable<medication> GetItems()
    //{
    //    return (from i in database.Table<medication>() select i).ToList();
    //}
    //public IEnumerable<medication> GetItemsNotDone()
    //{
    //    return database.Query<medication>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
    //}
    //public TodoItem GetItem(int id)
    //{
    //    return database.Table<medication>().FirstOrDefault(x => x.ID == id);
    //}


    public partial class FamilyVitals : ContentPage
    {
        public FamilyVitals()
        {
            /* blood presure items */
            var BloodPressureStatus = new Label()
            {
                Text = "Heart Rate",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var BloodPressureStatusPic = new Image { Aspect = Aspect.AspectFit };
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
            var BodyTempStatusPic = new Image { Aspect = Aspect.AspectFit };
            {
                BodyTempStatusPic.Source = ImageSource.FromFile("BodyTemp.jpg");
            };

            /*--------------*/
           
            var ExcerciseMonitor = new Label()
            {
                Text = "Excercise",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var ExcerciseMonitorPic = new Image { Aspect = Aspect.AspectFit };
            {
                ExcerciseMonitorPic.Source = ImageSource.FromFile("Exercise.jpg");
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
                    new RowDefinition{Height=GridLength.Auto},
					new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    },
                ColumnDefinitions ={
                    new ColumnDefinition{ Width=GridLength.Auto},
					new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star)},
                }
            };

            /*fill blood presure stack */
            StackBloodPressure.Children.Add(BloodPressureStatus);
            //StackBloodPresure.Children.Add(BloodPresureHigh);
            //StackBloodPresure.Children.Add(BloodPresureLow);

            /*fill body temp stack*/
            StackBodyTemp.Children.Add(BodyTempStatus);

            /*fill Excertion stack*/
            ExcertionMonitor.Children.Add(ExcerciseMonitor);

            /*fill monitoring grids*/
            //MonitoringGrids.Children.Add (BloodPresureStatus,1,1);
            //MonitoringGrids.Children.Add (BloodPresureHigh,1,1);
            MonitoringGrids.Children.Add(StackBloodPressure, 1, 1);            
            MonitoringGrids.Children.Add(BloodPressureStatusPic, 1, 2);


            MonitoringGrids.Children.Add(BodyTempStatus, 1, 3);
            MonitoringGrids.Children.Add(BodyTempStatusPic, 1, 4);


            MonitoringGrids.Children.Add(ExcerciseMonitor, 1, 5);
            MonitoringGrids.Children.Add(ExcerciseMonitorPic, 1, 6);



            /*grid style*/
            this.Padding = new Thickness(10, 10, 10, 10);
            this.Content = MonitoringGrids;

        }
    }
}
