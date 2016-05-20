using System;
using System.Collections.Generic;
using Xamarin.Forms;
using wellnet.UI;
namespace wellnet
{
	public partial class StartupMenu : ContentPage
	{
		
		public StartupMenu ()
		{
			/*draw menu buttons */
			var patientViewBtn = new Button ()
			{
				Text="Patient view",
				TextColor=Color.Red,
				BorderRadius=2,
				BorderWidth=2,
				BorderColor=Color.Blue,
				FontSize=Device.GetNamedSize(NamedSize.Large,typeof(Button))                
			};
			var familiyViewBtn = new Button ()
			{
				Text="Family view",
				TextColor=Color.Red,
				BorderRadius=2,
				BorderWidth=2,
				BorderColor=Color.Blue,
				FontSize=Device.GetNamedSize(NamedSize.Large,typeof(Button))
			};
			var doc_nursBtn = new Button ()
			{
				Text="Doc/Nurse view",
				TextColor=Color.Red,
				BorderRadius=2,
				BorderWidth=2,
				BorderColor=Color.Blue,
				FontSize=Device.GetNamedSize(NamedSize.Large,typeof(Button))
			};
	       /* draw button stack */
			var MenuStack = new StackLayout() 
			{
				Spacing=10,
				VerticalOptions=LayoutOptions.FillAndExpand,
			};
		    /* fill the stack with buttons*/
			MenuStack.Children.Add (patientViewBtn);
			MenuStack.Children.Add (familiyViewBtn);
			MenuStack.Children.Add (doc_nursBtn);
			/* set click listener */
			//MenuButtonController menu = new MenuButtonController ();
			patientViewBtn.Clicked += onPatientButtonClicked;
			doc_nursBtn.Clicked += onDoc_NurseButtonClicked ;
			familiyViewBtn.Clicked += onFamilyButtonClicked ;

	        /* fill the content page*/
			this.Content = MenuStack;

		}

		/*button listeners  */
		public async void onPatientButtonClicked(object sender, EventArgs e)
		{
			//todo: Patient view

		}
		public async void onFamilyButtonClicked(object sender, EventArgs e)
		{
            //todo: Family view
            await Navigation.PushAsync(new FamilyPage());
		}
		public async void onDoc_NurseButtonClicked(object sender, EventArgs e)
		{
			var database = new DBInit ();
			//await Navigation.PushAsync(new PatientMonitoringPage());
			await Navigation.PushAsync(new PaitentListPage(database));
		}

	}
}

