using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.UI
{
    public partial class FamilyMedication : ContentPage
    {
        public FamilyMedication()
        {

            var Header = new Label()
            {
                Text = "Medication",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var Dose = new Label()
            {
                Text = "mg",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var vMTime = new Label()
            {
                Text = "Time",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            var Medication01 = new Label()
            {
                Text = "Atenol",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            var Medication01_Dose = new Label()
            {
                Text = "50",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            var Medication01_Time = new Label()
            {
                Text = "am",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };


            var Medication02 = new Label()
            {
                Text = "Asprin",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            var Medication02_Dose = new Label()
            {
                Text = "100",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            var Medication02_Time = new Label()
            {
                Text = "am",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            var Medication03 = new Label()
            {
                Text = "Hydrochlothiazide",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            var Medication03_Dose = new Label()
            {
                Text = "300/12.5",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            var Medication03_Time = new Label()
            {
                Text = "pm",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            /* body temperature items*/
            var Medication04 = new Label()
            {
                Text = "Rosuvastatin",
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            var Medication04_Dose = new Label()
            {
                Text = "5",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            var Medication04_Time = new Label()
            {
                Text = "am",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            /*--------------*/

            var BackgroundGrid = new Image();

            /*-----stacklayouts---*/
            var vHeader = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var vDose = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var vTime = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };


            var Medication_01 = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var Medication_02 = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var Medication_03 = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var Medication_04 = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            var Medication_01Dose = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var Medication_02Dose = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var Medication_03Dose = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var Medication_04Dose = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var Medication_01Time = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var Medication_02Time = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var Medication_03Time = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var Medication_04Time = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /*monitoring grids layout */
            var MedicationGrid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions ={
                    new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    },
                ColumnDefinitions ={
                    new ColumnDefinition{ Width=GridLength.Auto},                               // MedicationType
                    new ColumnDefinition{ Width=GridLength.Auto},                               // Dose
                    new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star)},         //Time
                }
            };

            /*fill Medication grids*/
            MedicationGrid.Children.Add(Header, 0, 0);
            MedicationGrid.Children.Add(Dose, 1, 0);
            MedicationGrid.Children.Add(vMTime, 2, 0);


            MedicationGrid.Children.Add(Medication01, 0, 2);
            MedicationGrid.Children.Add(Medication01_Dose, 1, 2);
            MedicationGrid.Children.Add(Medication01_Time, 2, 2);

            MedicationGrid.Children.Add(Medication02, 0, 3);
            MedicationGrid.Children.Add(Medication02_Dose, 1,3);
            MedicationGrid.Children.Add(Medication02_Time, 2, 3);

            MedicationGrid.Children.Add(Medication03, 0, 4);
            MedicationGrid.Children.Add(Medication03_Dose, 1, 4);
            MedicationGrid.Children.Add(Medication03_Time, 2, 4);

            MedicationGrid.Children.Add(Medication04, 0, 5);
            MedicationGrid.Children.Add(Medication04_Dose, 1, 5);
            MedicationGrid.Children.Add(Medication04_Time, 2, 5);


            /*grid style*/
            this.Padding = new Thickness(10, 10, 10, 10);
            this.Content = MedicationGrid;





        }
    }
}
