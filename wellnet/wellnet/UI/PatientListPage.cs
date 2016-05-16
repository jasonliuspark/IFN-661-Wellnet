using System;
using System.Collections.Generic;
using System.IO;

using Xamarin.Forms;
using wellnet;
using SQLite;
namespace wellnet
{
	public partial class PaitentListPage : ContentPage
	{
		private DBInit _db;
		public PaitentListPage(DBInit database)
		{	
			_db = database;
			Title = "Patient List";

			//get detail item source
			var ptDetails = _db.GetDetails ();
            //var status = _db.GetStatus();
            // var join = new JointDetails(ptDetails,status);
            int patientListRowHeight = patientListItem.RowHeight;
			//set properties to the listview "patientList" following Patient List XAML
			ListView patientList = new ListView();
            patientList.ItemsSource=ptDetails;
           
			patientList.ItemTemplate=new DataTemplate(typeof(patientListItem));
			patientList.RowHeight = patientListRowHeight;

            //todo tap listener item index 0516Jack Test merge table
            patientList.ItemTapped += (sender, args) =>
            {   
				var currentPatientDetail = args.Item as PatientDetails;
				if (currentPatientDetail == null)
					return;
				Navigation.PushAsync(new PatientMonitoringPage(currentPatientDetail));
				patientList.SelectedItem = null;
            };
            //Title = "Patients"; //Mainpage.title
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
            var bodyTempLabelT = new Label
            {
                FontSize = 13,
                TextColor = Color.FromHex("#666"),
                Text="Temp:"
            };

            var heartLabelT = new Label
            {
                FontSize = 13,
                TextColor = Color.FromHex("#666"),
                Text = "Heart Rate:"
            };

            var bodyTempLabel = new Label {
				FontSize = 13,
				TextColor = Color.FromHex ("#666")
			};
			bodyTempLabel.SetBinding(Label.TextProperty,"Status");

			var heartRateLabel = new Label {
				FontSize = 13,
				TextColor = Color.FromHex ("#666")
			};
			heartRateLabel.SetBinding(Label.TextProperty, "Status");

		
			var ageLabelT = new Label
			{
				FontSize = 19,
				TextColor = Color.Black,
				Text = "Age:"
			};

			var ageLabel = new Label {
                FontAttributes = FontAttributes.Bold,
                FontFamily = "HelveticaNeue-Medium",
                FontSize = 19,
                TextColor = Color.Black
            };
            ageLabel.SetBinding(Label.TextProperty, "Age");


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
                    bodyTempLabelT,
					bodyTempLabel,
                    heartLabelT,
					heartRateLabel
				}
			};

			var profileStack = new StackLayout {
				WidthRequest = 245,
				Children = {
					nameStack,
					measurementStack
				}
			};
			var statusStack = new StackLayout {
				Children = {
					//statusLabel,
					//locationLabel
					ageLabelT,
                    ageLabel
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

