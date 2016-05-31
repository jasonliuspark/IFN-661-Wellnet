using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.Views.FamilyViews
{
    public partial class FamilyAgenda : ContentPage
    {
        public FamilyAgenda()
        {
            InitializeComponent();
            /* Agenda */
			NavigationPage.SetTitleIcon (this,"wellnet_logo_mini.png");
            var AgendaStatus = new Label()
            {
                Text = "Agenda" ,
                TextColor = Color.FromHex("#4CAF50"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
             var AgendaStatusPic = new Image { Aspect = Aspect.AspectFit };
            {
                AgendaStatusPic.Source = ImageSource.FromFile("SmallAgenda.jpg");
            };

             var BackgroundGrid = new Image();

            /*-----stacklayouts---*/
            /*  stack for calendar  */
            var Agenda_Status = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.Fill,
            };

            /*monitoring grids layout */
            var AgendaGrid = new Grid
            {
                VerticalOptions = LayoutOptions.Start,   //.FillAndExpand,
                RowDefinitions ={
                    new RowDefinition{Height=530},
                    //new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    },
                ColumnDefinitions ={
                    new ColumnDefinition{ Width=360},
                    //new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star)},
                }
            };

            /*fill blood presure stack */
            AgendaGrid.Children.Add(AgendaStatusPic);
 
            /*grid style*/
            //this.Padding = new Thickness(30, 30, 10, 10);
            this.Content = AgendaGrid;
        }
    }
}
