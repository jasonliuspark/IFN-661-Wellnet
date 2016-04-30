using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace wellnet
{
	public partial class Mainpage : ContentPage
	{
		public Mainpage ()
		{	
			List<Patient>patientListSource = new List<Patient> {
				new Patient { firstName = "Doris", lastName = "Anderson", bodyTemp = 37, heartRate = 90, location = "QUT KG", status = "Emergency"},
				new Patient { firstName = "Kelly", lastName = "Wood", bodyTemp = 37, heartRate = 72, location = "QUT KG", status = "Normal"},
				new Patient { firstName = "Joe", lastName = "Doe", bodyTemp = 37, heartRate = 88, location = "QUT KG", status = "Normal"},
				new Patient { firstName = "Jennifer", lastName = "Ruhle", bodyTemp = 37, heartRate = 96, location = "QUT KG", status = "Normal"},
				new Patient { firstName = "Wesley", lastName = "Stevenson", bodyTemp = 37, heartRate = 77, location = "QUT KG", status = "Normal"}
			}; // patient list data for testing

			DataTemplate patientListTemplate = new DataTemplate (typeof(patientListItem));


			int patientListRowHeight = patientListItem.RowHeight;

			//set properties to the listview "patientList" following Mainpage XAML
			ListView patientList = new ListView();
			patientList.ItemsSource = patientListSource;
			patientList.ItemTemplate = patientListTemplate;
			patientList.RowHeight = patientListRowHeight;

			patientList.ItemTapped += (sender, e) => {
				patientList.SelectedItem = null;
				Navigation.PushAsync(new FruitDetailPage(e.Item as Patient));
			};

			Title = "Patients"; //Mainpage.title
			Content = patientList; //Mainpage.Content
		}
	}

	public class Patient
	{
		public string firstName { get; set; }

		public string lastName { get; set; }

		public int bodyTemp { get; set; }

		public int heartRate { get; set;}

		public string location { get; set;}

		public string status { get; set;}

	}

	public class patientListItem: ViewCell 
	{
		public const int RowHeight = 65;

		public patientListItem()
		{
			var firstNameLabel = new Label { 
				FontAttributes = FontAttributes.Bold,
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 22,
				TextColor = Color.Black
			
			};
			firstNameLabel.SetBinding(Label.TextProperty, "firstName");

			var lastNameLabel = new Label { 
				FontAttributes = FontAttributes.Bold,
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 22,
				TextColor = Color.Black
			};
			lastNameLabel.SetBinding(Label.TextProperty, "lastName");

			var bodyTempLabel = new Label {
				FontSize = 16,
				TextColor = Color.FromHex ("#666")
			};
			bodyTempLabel.SetBinding(Label.TextProperty, "bodyTemp",stringFormat: "Temp: {0}`C");

			var heartRateLabel = new Label {
				FontSize = 16,
				TextColor = Color.FromHex ("#666")
			};
			heartRateLabel.SetBinding(Label.TextProperty, "heartRate", stringFormat: "Pulse: {0}");

			var locationLabel = new Label {
				FontSize = 16,
				TextColor = Color.FromHex ("#666")
			};
			locationLabel.SetBinding(Label.TextProperty, "location", stringFormat: "Room: {0}");

			var statusLabel = new Label {
				FontAttributes = FontAttributes.Bold,
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 22,
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

	public class FruitDetailPage: ContentPage
	{
		public FruitDetailPage(Patient patient)
		{
			Title = patient.firstName;
			Content = new Label {
				Text = patient.status,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}

