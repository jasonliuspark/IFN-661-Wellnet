using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace wellnet
{
	public partial class PatientMonitoringPage : ContentPage
	{
		public PatientMonitoringPage ()
		{
			var BloodPresureStatus = new Label () {Text = "BloodPresure",
				TextColor = Color.Red,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			var BloodPresureHigh = new Label () {
				Text = "90",
				TextColor = Color.Blue,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			var BloodPresureLow = new Label ();
			var BodyTempStatus = new Label ();
			var OxygenSatuationLevel = new Label ();
			var OxygenFigure = new Label ();
			var HeartRate = new Label ();
			var EcgMockup = new WebView ()
			{
				Source=new UrlWebViewSource{
					Url="http://rs106.pbsrc.com/albums/m269/mekonio/2709-51.gif~c200",
				},
				VerticalOptions=LayoutOptions.FillAndExpand,

			};
			var BackgroundGrid = new Image ();
			var StackBloodPresure = new StackLayout ()
			{
				
			};
			var StackBodyTempStack = new StackLayout ();
			var OxygenStack = new StackLayout ();

			var MonitoringGrids=new Grid{
				VerticalOptions=LayoutOptions.FillAndExpand,
				RowDefinitions={
					new RowDefinition{Height=GridLength.Auto},
					//new RowDefinition{Height=GridLength.Auto},
					//new RowDefinition{Height=GridLength.Auto},
					//new RowDefinition{Height=GridLength.Auto},
					new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
					new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
					new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
					},
				ColumnDefinitions={
					new ColumnDefinition{ Width=GridLength.Auto},
					new ColumnDefinition{ Width=GridLength.Auto},
					//new ColumnDefinition{ Width=GridLength.Auto},
					//new ColumnDefinition{ Width=GridLength.Auto},
					new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star)},
				}
			};

			MonitoringGrids.Children.Add (BloodPresureStatus,1,1);
			//MonitoringGrids.Children.Add (BloodPresureHigh,1,1);
			MonitoringGrids.Children.Add (EcgMockup, 2,2);
			this.Padding = new Thickness (10,10,10,10);
			this.Content = MonitoringGrids;


		}
	}
}

