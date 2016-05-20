using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace wellnet
{
	public partial class PatientListPage : ContentPage
	{
		//private DBInit _db;
		//public PaitentListPage(DBInit database)
		public PatientListPage( )
		{	
			//_db = database;
			Title = "Patient List";

			//get detail item source
			//var ptDetails = _db.GetDetails ();

			int patientListRowHeight = patientListItem.RowHeight;
			//set properties to the listview "patientList" following Patient List XAML
			ListView patientList = new ListView();
			//patientList.ItemsSource=ptDetails;
			patientList.ItemTemplate=new DataTemplate(typeof(patientListItem));
			patientList.RowHeight = patientListRowHeight;

			//todo tap listenner
//			patientList.ItemTapped += (sender, e) => {
//				patientList.SelectedItem = null;
//				Navigation.PushAsync(new FruitDetailPage(e.Item as Patient));
//			};
			//Title = "Patients"; //Mainpage.title

			BindingContext = App.Locator.ptlist;
			Content = patientList; //Mainpage.Content
		}
	}

	public class patientListItem: ViewCell 
	{
		public const int RowHeight = 65;

		public patientListItem()
		{
			var firstNameLabel = new Label { 
				FontAttributes = FontAttributes.Bold,
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 19,
				TextColor = Color.Black
			
			};
			firstNameLabel.SetBinding(Label.TextProperty, "FirstName");

			var lastNameLabel = new Label { 
				FontAttributes = FontAttributes.Bold,
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 19,
				TextColor = Color.Black
			};
			lastNameLabel.SetBinding(Label.TextProperty, "LastName");
			/* todo join the tables and fill the bindings*/
			var bodyTempLabel = new Label {
				FontSize = 13,
				TextColor = Color.FromHex ("#666")
			};
			bodyTempLabel.SetBinding(Label.TextProperty, "bodyTemp",stringFormat: "Temp: {0}`C");

			var heartRateLabel = new Label {
				FontSize = 13,
				TextColor = Color.FromHex ("#666")
			};
			heartRateLabel.SetBinding(Label.TextProperty, "heartRate", stringFormat: "Pulse: {0}");

			var locationLabel = new Label {
				FontSize = 13,
				TextColor = Color.FromHex ("#666")
			};
			locationLabel.SetBinding(Label.TextProperty, "location", stringFormat: "Room: {0}");

			var statusLabel = new Label {
				FontAttributes = FontAttributes.Bold,
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 19,
				TextColor = Color.Black
			};
			statusLabel.SetBinding(Label.TextProperty, "status");


			var nameStack = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Children = {
					firstNameLabel,
					lastNameLabel
				}
			};

			var measurementStack = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Children = {
					bodyTempLabel,
					heartRateLabel
				}
			};

			var profileStack = new StackLayout {
				WidthRequest = 195,
				Children = {
					nameStack,
					measurementStack
				}
			};
			var statusStack = new StackLayout {
				Children = {
					statusLabel,
					locationLabel
				}
			};
			var combinedStack = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Padding = new Thickness(5),
				Children = {
					profileStack,
					statusStack
				}
			};
			this.View = combinedStack;
		}
	}

//	public class FruitDetailPage: ContentPage
//	{
//		public FruitDetailPage(Patient patient)
//		{
//			Title = patient.firstName;
//			Content = new Label {
//				Text = patient.status,
//				HorizontalOptions = LayoutOptions.CenterAndExpand,
//				VerticalOptions = LayoutOptions.CenterAndExpand,
//			};
//		}
//	}
}

