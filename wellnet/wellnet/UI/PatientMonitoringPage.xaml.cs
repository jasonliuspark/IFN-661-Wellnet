using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace wellnet
{
	public partial class PatientMonitoringPage : ContentPage
	{
		public PatientMonitoringPage ()
		{
			/* blood presure items */
			var BloodPresureStatus = new Label () {Text = "BloodPresure",
				TextColor = Color.Red,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			var BloodPresureHigh = new Label () {
				Text = "120",
				TextColor = Color.Blue,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			var BloodPresureLow = new Label ()
			{
				Text = "90",
				TextColor = Color.Blue,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};

			/* body temperature items*/
			var BodyTempStatus = new Label ()
			{
				Text="Temperature",
				TextColor=Color.Red,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			var BodyTempFigure = new Label ()
			{
				Text="36",
				TextColor=Color.Blue,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			/*--------------*/
			var OxygenSatuationLevel = new Label ()
			{
				Text="Oxygen Satuation: "+"normal",
				TextColor=Color.Blue,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			var OxygenFigure = new Label ()
			{
				Text="95%",
				TextColor=Color.Red,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			/*heart reate */
			var HeartRateStatus = new Label ()
			{ 
				Text="Heart Rate: "+"normal",
				TextColor=Color.Red,
				FontSize=Device.GetNamedSize(NamedSize.Large,typeof(Label))		
			};

			var HeartRateFigure = new Label ()
			{
				Text="75",
				TextColor=Color.Blue,
				FontSize=Device.GetNamedSize(NamedSize.Large,typeof(Label)),
			};

			var EcgMockup = new WebView ()
			{
				Source=new UrlWebViewSource{
					Url="http://rs106.pbsrc.com/albums/m269/mekonio/2709-51.gif~c200",
				},
				VerticalOptions=LayoutOptions.FillAndExpand,

			};
			var BackgroundGrid = new Image ();

			/*-----stacklayouts---*/
			/*  stack for blood presure  */
			var StackBloodPresure = new StackLayout ()
			{
				Spacing=0,
				VerticalOptions=LayoutOptions.FillAndExpand,
			};
			/* stack for body temperature */
			var StackBodyTemp = new StackLayout ()
			{
				Spacing=0,
				VerticalOptions=LayoutOptions.FillAndExpand,
			};
			/* stack for oxygen stack*/
			var OxygenStack = new StackLayout ()
			{
				Spacing=0,
				VerticalOptions=LayoutOptions.FillAndExpand,
			};
			/* heart rate */
			var HeartStack = new StackLayout {
				Spacing = 0,
				VerticalOptions = LayoutOptions.FillAndExpand,
			};
			/*monitoring grids layout */
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
		
			/*fill blood presure stack */
			StackBloodPresure.Children.Add (BloodPresureStatus);
			StackBloodPresure.Children.Add (BloodPresureHigh);
			StackBloodPresure.Children.Add (BloodPresureLow);

			/*fill body temp stack*/
			StackBodyTemp.Children.Add (BodyTempStatus);
			StackBodyTemp.Children.Add (BodyTempFigure);
			//StackBodyTemp.Children.Add ();

			/*fill oxygen stack*/
			OxygenStack.Children.Add (OxygenSatuationLevel);
			OxygenStack.Children.Add (OxygenFigure);

			/* fill heart rate stack*/
			HeartStack.Children.Add (HeartRateStatus);
			HeartStack.Children.Add (HeartRateFigure);

			/*fill monitoring grids*/
			//MonitoringGrids.Children.Add (BloodPresureStatus,1,1);
			//MonitoringGrids.Children.Add (BloodPresureHigh,1,1);
			MonitoringGrids.Children.Add(StackBloodPresure,1,1);
			MonitoringGrids.Children.Add (EcgMockup, 2,2);
			MonitoringGrids.Children.Add (StackBodyTemp,2,1);
			MonitoringGrids.Children.Add (OxygenStack,1,2);
			MonitoringGrids.Children.Add (HeartStack,1,3);
			/*grid style*/
			this.Padding = new Thickness (10,10,10,10);
			this.Content = MonitoringGrids;


		}
	}
}

